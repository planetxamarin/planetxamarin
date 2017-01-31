using BlogMonster.Configuration;
using BlogMonster.Infrastructure.SyndicationFeedSources;
using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Threading;
using ThirdDrawer.Extensions.CollectionExtensionMethods;

namespace Firehose.Web.Infrastructure
{
    public class CombinedFeedSource
    {
        private readonly IAmACommunityMember[] _bloggers;
        private readonly Lazy<ISyndicationFeedSource> _combinedFeedSource;

        public CombinedFeedSource(IAmACommunityMember[] bloggers)
        {
            _bloggers = bloggers;
            _combinedFeedSource = new Lazy<ISyndicationFeedSource>(LoadFeeds, LazyThreadSafetyMode.PublicationOnly);
        }

        public SyndicationFeed Feed => _combinedFeedSource.Value.Feed;
        public IAmACommunityMember[] Bloggers => _bloggers;

        private ISyndicationFeedSource LoadFeeds()
        {
            var feedSources = (from blogger in _bloggers.AsParallel()
                               from uri in blogger.FeedUris
                               select TryLoadFeed(blogger, uri))
                .NotNull()
                .ToArray();

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

        private static ISyndicationFeedSource TryLoadFeed(IAmACommunityMember tamarin, Uri uri)
        {
            try
            {
                var iFilterMyBlogPosts = tamarin as IFilterMyBlogPosts;

                var filter = iFilterMyBlogPosts != null
                    ? (Func<SyndicationItem, bool>)iFilterMyBlogPosts.Filter
                    : (si => true);

                var feedSource = BlogMonsterBuilder
                    .FromUrl(uri)
                    .WithFilter(filter)
                    .Grr();

                // Poke it, to see if we can really reach it
                var request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = "HEAD";

                var response = (HttpWebResponse)request.GetResponse();

                // If return code is not success or redirect, it's no good
                if ((int)response.StatusCode < 200 || (int)response.StatusCode > 399)
                    throw new Exception("Feed says no");

                return feedSource;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, $"{tamarin.FirstName} {tamarin.LastName}'s feed of {uri} failed to load.");

                // Not my problem if your feed asplodes but we at least won't crash the app for all the other nice people :)
                return null;
            }
        }
    }
}