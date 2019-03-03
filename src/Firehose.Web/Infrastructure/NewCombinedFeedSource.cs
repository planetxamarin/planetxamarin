using BlogMonster.Infrastructure.SyndicationFeedSources.Remote;
using Firehose.Web.Extensions;
using Polly;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace Firehose.Web.Infrastructure
{
    public class NewCombinedFeedSource
    {
        private HttpClient _httpClient;
        private Policy _policy;

        public IEnumerable<IAmACommunityMember> Tamarins { get; }

        public NewCombinedFeedSource(IEnumerable<IAmACommunityMember> tamarins)
        {
            EnsureHttpClient();

            Tamarins = tamarins;

            //_policy = new Policy.WaitAndRetryAsync(2, retry => TimeSpan.FromSeconds(retry * Math.Pow(2, retry))).
        }
        
        private void EnsureHttpClient()
        {
            if (_httpClient == null)
            {
                _httpClient = new HttpClient();
                _httpClient.DefaultRequestHeaders.UserAgent.Add(
                    new ProductInfoHeaderValue("PlanetXamarin", $"{GetType().Assembly.GetName().Version}"));
                _httpClient.Timeout = TimeSpan.FromSeconds(10);
            }
        }

        public Task<SyndicationFeed> LoadFeed(int? numberOfItems, string languageCode = "mixed")
        {
            IEnumerable<IAmACommunityMember> tamarins;
            if (languageCode == "mixed")
            {
                // use all tamarins
                tamarins = Tamarins;

                // todo try get from cache
            }
            else
            {
                tamarins = Tamarins.Where(t => t.FeedLanguageCode == languageCode);
            }

            //var feedTasks = tamarins.Select(t => ReadFeed(t.))
        }

        private async Task<IEnumerable<SyndicationItem>> ReadFeed(string feedUri, Func<SyndicationItem, bool> filter)
        {
            HttpResponseMessage response;
            try
            {
                response = await _httpClient.GetAsync(feedUri).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    using (var feedStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var reader = XmlReader.Create(feedStream))
                    {
                        var feed = SyndicationFeed.Load(reader);
                        var filteredItems = feed.Items
                            .Where(item => filter(item));

                        return filteredItems;
                    }
                }
            }
            catch (HttpRequestException hex)
            {
                throw new RemoteSyndicationFeedFailedException("Loading remote syndication feed failed", hex)
                    .WithData("FeedUri", feedUri);
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

        private SyndicationFeed GetCombinedFeed(IEnumerable<SyndicationItem> items, string languageCode, 
            IEnumerable<IAmACommunityMember> tamarins, int? numberOfItems)
        {
            var beforeNowItems = items
                .Where(item =>
                    item.LastUpdatedTime.UtcDateTime <= DateTimeOffset.UtcNow &&
                    item.PublishDate.UtcDateTime <= DateTimeOffset.UtcNow);

            if (numberOfItems.HasValue)
            {
                beforeNowItems = beforeNowItems.Take(numberOfItems.Value);
            }

            var orderedItems = beforeNowItems.OrderByDescending(item => item.PublishDate);

            var feed = new SyndicationFeed(
                ConfigurationManager.AppSettings["RssFeedTitle"],
                ConfigurationManager.AppSettings["RssFeedDescription"],
                new Uri(ConfigurationManager.AppSettings["BaseUrl"]),
                orderedItems)
            {
                ImageUrl = new Uri(ConfigurationManager.AppSettings["RssFeedImageUrl"]),
                Copyright = new TextSyndicationContent("The copyright for each post is retained by its author."),
                Language = languageCode
            };

            foreach(var tamarin in tamarins)
            {
                feed.Contributors.Add(new SyndicationPerson(
                    tamarin.EmailAddress, $"{tamarin.FirstName} {tamarin.LastName}", tamarin.WebSite.ToString()));
            }

            return feed;
        }

        private static Func<SyndicationItem, bool> GetFilterFunction(IAmACommunityMember tamarin)
        {
            if (tamarin is IFilterMyBlogPosts filterMyBlogPosts)
            {
                return filterMyBlogPosts.Filter;
            }

            return SyndicationItemExtensions.ApplyDefaultFilter;
        }

        private static bool TryFilter(SyndicationItem item, Func<SyndicationItem, bool> filterFunc)
        {
            try
            {
                return filterFunc(item);
            }
            catch (NullReferenceException)
            {
                // the authors' filter is derped
                // try some sane defaults

                return item.ApplyDefaultFilter();
            }
        }
    }
}