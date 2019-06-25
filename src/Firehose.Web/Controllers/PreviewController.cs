using System.Linq;
using System.ServiceModel.Syndication;
using System.Web.Mvc;
using Firehose.Web.Infrastructure;
using Firehose.Web.ViewModels;

namespace Firehose.Web.Controllers
{
    public class PreviewController : BaseController
    {
        private readonly NewCombinedFeedSource _combinedFeedSource;

        public PreviewController(NewCombinedFeedSource combinedFeedSource)
        {
            _combinedFeedSource = combinedFeedSource;
        }

        [Route("preview")]
        public ViewResult Index(int? numPosts = 50)
        {
            var feed = GetFeed(numPosts);
            return View(new PreviewViewModel
            {
                Feed = feed,
                Bloggers = _combinedFeedSource.Tamarins.ToArray()
            });
        }

        private SyndicationFeed GetFeed(int? numPosts)
        {
            var originalFeed = _combinedFeedSource.LoadFeed(numPosts, "en").GetAwaiter().GetResult();
            return originalFeed;
        }
    }
}