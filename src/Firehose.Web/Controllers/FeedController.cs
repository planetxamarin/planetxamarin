using System;
using System.Globalization;
using System.ServiceModel.Syndication;
using System.Web.Mvc;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Controllers
{
    public class FeedController : BaseController
    {
        private readonly NewCombinedFeedSource _combinedFeedSource;

        public FeedController(NewCombinedFeedSource combinedFeedSource)
        {
            _combinedFeedSource = combinedFeedSource;
        }

        [Route("feed")]
        public RssFeedResult Index(int? numPosts = 50, string lang = "")
        {
            var feed = GetFeed(numPosts, lang);
            return new RssFeedResult(feed);
        }

        private SyndicationFeed GetFeed(int? numPosts, string lang = "")
        {
            SyndicationFeed originalFeed = null;

            try
            {
                string language = null;
                if (!string.IsNullOrEmpty(lang))
                    language = CultureInfo.CreateSpecificCulture(lang).Name;

                originalFeed = _combinedFeedSource.LoadFeed(numPosts, language).GetAwaiter().GetResult();
                return originalFeed;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);

                return originalFeed;
            }
        }
    }
}