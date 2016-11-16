using System.Linq;
using System.Reflection;
using System.ServiceModel.Syndication;
using System.Web.Mvc;
using BlogMonster.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Controllers
{
    public class FeedController : Controller
    {
        private readonly CombinedFeedSource _combinedFeedSource;

        public FeedController(CombinedFeedSource combinedFeedSource)
        {
            _combinedFeedSource = combinedFeedSource;
        }

        public RssFeedResult Rss(int? numPosts = 50)
        {
            var feed = GetFeed(numPosts);
            return new RssFeedResult(feed);
        }

        public ViewResult Read(int? numPosts = 50)
        {
            var feed = GetFeed(numPosts);
            return View(feed);
        }

        private SyndicationFeed GetFeed(int? numPosts)
        {
            var originalFeed = _combinedFeedSource.Feed;
            if (numPosts == null) return originalFeed;

            var items = _combinedFeedSource.Feed.Items
                                           .OrderByDescending(item => item.PublishDate)
                                           .Take((int) numPosts)
                                           .ToArray();

            var shorterFeed = originalFeed.Clone(false);
            var itemsField = shorterFeed.GetType().GetField("items", BindingFlags.Instance | BindingFlags.NonPublic);
            itemsField.SetValue(shorterFeed, items);

            return shorterFeed;
        }
    }
}