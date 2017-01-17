using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel.Syndication;
using System.Web.Mvc;
using BlogMonster.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Controllers
{
    public class PreviewController : Controller
    {
        private readonly CombinedFeedSource _combinedFeedSource;

        public PreviewController(CombinedFeedSource combinedFeedSource)
        {
            _combinedFeedSource = combinedFeedSource;
        }


        [Route("preview")]
        public ViewResult Index(int? numPosts = 50)
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
                                           .Take((int)numPosts)
                                           .ToArray();

            var shorterFeed = originalFeed.Clone(false);
            var itemsField = shorterFeed.GetType().GetField("items", BindingFlags.Instance | BindingFlags.NonPublic);
            itemsField.SetValue(shorterFeed, items);

            return shorterFeed;
        }
    }
}