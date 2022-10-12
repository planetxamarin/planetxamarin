using System.Globalization;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;
using Firehose.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Firehose.Web.Controllers
{
    public class PreviewController : BaseController
    {
        private readonly NewCombinedFeedSource _combinedFeedSource;
		private IConfiguration _configuration;

        public PreviewController(NewCombinedFeedSource combinedFeedSource, IConfiguration config)
        {
            _combinedFeedSource = combinedFeedSource;
			_configuration = config;
        }

        [Route("preview")]
        public ViewResult Index()
        {
            var feed = GetFeed();
            return View(new PreviewViewModel(feed, _combinedFeedSource.Tamarins.ToArray(), _configuration));
        }

        private SyndicationFeed GetFeed()
        {
			var lang = CultureInfo.CreateSpecificCulture("en").Name;
			var feed = _combinedFeedSource.LoadFeed(50, lang).GetAwaiter().GetResult();
            return feed;
        }
    }
}