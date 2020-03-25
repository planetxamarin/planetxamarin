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
        public RssFeedResult Index(int? numPosts = 150, string lang = "mixed")
        {
            var feed = GetFeed(numPosts, lang);
            return new RssFeedResult(feed);
        }

        private SyndicationFeed GetFeed(int? numPosts = 150, string lang = "mixed")
        {
            SyndicationFeed originalFeed = null;

            try
            {
                string language = null;
                if (!string.IsNullOrEmpty(lang) && lang != "mixed")
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