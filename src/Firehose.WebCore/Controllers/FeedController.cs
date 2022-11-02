using System;
using System.Globalization;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<RssFeedResult> Index(int? numPosts = 150, string lang = "mixed")
        {
            var feed = await GetFeed(numPosts, lang);
            return new RssFeedResult(feed);
        }

        private async Task<SyndicationFeed> GetFeed(int? numPosts = 150, string lang = "mixed")
        {
            SyndicationFeed originalFeed = null;

            try
            {
                string language = null;
                if (!string.IsNullOrEmpty(lang) && lang != "mixed")
                    language = CultureInfo.CreateSpecificCulture(lang).Name;

				originalFeed = await _combinedFeedSource.LoadFeed(numPosts, language);
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