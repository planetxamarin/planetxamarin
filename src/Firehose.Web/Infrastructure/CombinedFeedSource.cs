using BlogMonster.Configuration;
using BlogMonster.Infrastructure.SyndicationFeedSources;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.ServiceModel.Syndication;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using BlogMonster;
using BlogMonster.Infrastructure;
using BlogMonster.Infrastructure.SyndicationFeedSources.Remote;
using ThirdDrawer.Extensions.CollectionExtensionMethods;

namespace Firehose.Web.Infrastructure
{
    public class CombinedFeedSource
    {
        private static readonly HttpClient HttpClient = new HttpClient();
        private readonly Lazy<Cached<ISyndicationFeedSource>> _combinedFeedSource;

        public CombinedFeedSource(IAmACommunityMember[] bloggers)
        {
            Bloggers = bloggers;
            var cached = new Cached<ISyndicationFeedSource>(TimeSpan.FromHours(1), new SystemClock(), LoadFeeds);
            _combinedFeedSource = new Lazy<Cached<ISyndicationFeedSource>>(() => cached, LazyThreadSafetyMode.PublicationOnly);
            HttpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("PlanetXamarin", $"{GetType().Assembly.GetName().Version}"));
            HttpClient.Timeout = TimeSpan.FromMinutes(1);
        }

        public SyndicationFeed Feed => _combinedFeedSource.Value.Value.Feed;

        public IAmACommunityMember[] Bloggers { get; }

        private ISyndicationFeedSource LoadFeeds()
        {
            var feedTasks = Bloggers.SelectMany(b => b.FeedUris, TryLoadFeedAsync);
            var feedSources = Task.WhenAll(feedTasks).GetAwaiter().GetResult().NotNull().ToArray();

            return BlogMonsterBuilder.FromOtherFeedSources(feedSources.First(), feedSources.Skip(1).ToArray())
                .WithRssSettings(
                    new RssFeedSettings(ConfigurationManager.AppSettings["BaseUrl"],
                        ConfigurationManager.AppSettings["RssFeedTitle"],
                        ConfigurationManager.AppSettings["RssFeedDescription"],
                        new SyndicationPerson(ConfigurationManager.AppSettings["SyndicationPersonEmail"],
                        ConfigurationManager.AppSettings["SyndicationPersonName"],
                        ConfigurationManager.AppSettings["BaseUrl"]),
                        ConfigurationManager.AppSettings["RssFeedImageUrl"],
                        "en-US",
                        "The copyright for each post is retained by its author.",
                        new Uri(ConfigurationManager.AppSettings["BaseUrl"])))
                .Grr();
        }

        private async Task<ISyndicationFeedSource> TryLoadFeedAsync(IAmACommunityMember tamarin, Uri uri)
        {
            try
            {
                var iFilterMyBlogPosts = tamarin as IFilterMyBlogPosts;

                var filter = iFilterMyBlogPosts != null
                    ? (Func<SyndicationItem, bool>)iFilterMyBlogPosts.Filter
                    : (si => true);

                var feedSource = new DummyRemoteSyndicationFeedSource();

                var feed = await FetchAsync(uri, filter).ConfigureAwait(false);
                feedSource.Feed = feed;

                return feedSource;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, $"{tamarin.FirstName} {tamarin.LastName}'s feed of {uri} failed to load.");

                // Not my problem if your feed asplodes but we at least won't crash the app for all the other nice people :)
                return null;
            }
        }

        public async Task<SyndicationFeed> FetchAsync(Uri feedUri, Func<SyndicationItem, bool> filter)
        {
            HttpResponseMessage response;
            try
            {
                response = await HttpClient.GetAsync(feedUri).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    using (var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var reader = new StreamReader(stream))
                    using (var xmlReader = XmlReader.Create(reader))
                    {
                        var feed = SyndicationFeed.Load(xmlReader);
                        var filteredItems = feed.Items
                            .Where(filter)
                            .ToArray();

                        var itemsField = feed.GetType().GetField("items", BindingFlags.Instance | BindingFlags.NonPublic);
                        itemsField?.SetValue(feed, filteredItems);
                        return feed;
                    }
                }
            }
            catch (WebException ex)
            {
                throw new RemoteSyndicationFeedFailedException("Loading remote syndication feed timed out", ex)
                    .WithData("FeedUri", feedUri);
            }

            throw new RemoteSyndicationFeedFailedException("Loading remote syndication feed failed.")
                .WithData("FeedUri", feedUri)
                .WithData("HttpStatusCode", (int)response.StatusCode);
        }
    }

    public class DummyRemoteSyndicationFeedSource : ISyndicationFeedSource
    {
        public SyndicationFeed Feed { get; set; }
    }

    internal static class ExceptionExtensions
    {
        public static TException WithData<TException>(this TException exception, string key, object value) where TException : Exception
        {
            exception.Data[key] = value;
            return exception;
        }
    }
}