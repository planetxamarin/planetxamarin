using BlogMonster.Configuration;
using BlogMonster.Infrastructure.SyndicationFeedSources;
using System;
using System.Configuration;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading;
using ThirdDrawer.Extensions.CollectionExtensionMethods;

namespace Firehose.Web.Infrastructure
{
    public class CombinedFeedSource
    {
        private readonly IAmAReadifarian[] _readifarians;
        private readonly Lazy<ISyndicationFeedSource> _combinedFeedSource;

        public CombinedFeedSource(IAmAReadifarian[] readifarians)
        {
            _readifarians = readifarians;
            _combinedFeedSource = new Lazy<ISyndicationFeedSource>(LoadFeeds, LazyThreadSafetyMode.PublicationOnly);
        }

        public SyndicationFeed Feed
        {
            get { return _combinedFeedSource.Value.Feed; }
        }

        private ISyndicationFeedSource LoadFeeds()
        {
            var feedSources = (from readifarian in _readifarians.AsParallel()
                               from uri in readifarian.FeedUris
                               select TryLoadFeed(readifarian, uri))
                .NotNull()
                .ToArray();

            return BlogMonsterBuilder.FromOtherFeedSources(feedSources.First(), feedSources.Skip(1).ToArray())
                                     .WithRssSettings(new RssFeedSettings(ConfigurationManager.AppSettings["BaseUrl"],
                                                                          ConfigurationManager.AppSettings["RssFeedTitle"],
                                                                          ConfigurationManager.AppSettings["RssFeedDescription"],
                                                                          new SyndicationPerson(ConfigurationManager.AppSettings["SyndicationPersonEmail"], ConfigurationManager.AppSettings["SyndicationPersonName"], ConfigurationManager.AppSettings["BaseUrl"]),
                                                                          ConfigurationManager.AppSettings["RssFeedImageUrl"],
                                                                          "en-US",
                                                                          "The copyright for each post is retained by its author.",
                                                                          new Uri(ConfigurationManager.AppSettings["BaseUrl"])))
                                     .Grr();
        }

        private static ISyndicationFeedSource TryLoadFeed(IAmAReadifarian readifarian, Uri uri)
        {
            try
            {
                var iFilterMyBlogPosts = readifarian as IFilterMyBlogPosts;

                var filter = iFilterMyBlogPosts != null
                    ? (Func<SyndicationItem, bool>)iFilterMyBlogPosts.Filter
                    : (si => true);

                var feedSource = BlogMonsterBuilder
                    .FromUrl(uri)
                    .WithFilter(filter)
                    .Grr();
                var dummy = feedSource.Feed; // poke it to make sure it doesn't go bang.

                return feedSource;
            }
            catch (Exception)
            {
                // Not my problem if your feed asplodes but we at least won't crash the app for all the other nice people :)
                return null;
            }
        }
    }
}