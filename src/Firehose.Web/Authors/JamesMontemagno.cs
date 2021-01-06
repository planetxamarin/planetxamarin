using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JamesMontemagno : IWorkAtXamarinOrMicrosoft, IFilterMyBlogPosts
    {
        public string FirstName => "James";
        public string LastName => "Montemagno";
        public string StateOrRegion => "PNW";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => "is a Principal Lead Program Manager for .NET Community";
        public Uri WebSite => new Uri("https://montemagno.com");

        public IEnumerable<Uri> FeedUris
        {
            get 
			{
				return new Uri[]
				{
					new Uri("https://montemagno.com/rss"),
					new Uri("https://www.youtube.com/feeds/videos.xml?channel_id=UCENTmbKaTphpWV2R2evVz2A")
				};
			}
		}

        public string TwitterHandle => "JamesMontemagno";
        public string GravatarHash => "5df4d86308e585c879c19e5f909d8bfe";
        public string GitHubHandle => "jamesmontemagno";
        public GeoPosition Position => new GeoPosition(47.6541770, -122.3500000);
        public string FeedLanguageCode => "en";

		public bool Filter(SyndicationItem item)
		{
			if (item.Title?.Text?.ToLowerInvariant().Contains("xamarin") ?? false)
				return true;

			// This filters out only the posts that have the "xamarin" category
			// Not all blog posts have categories, please guard against this
			return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("xamarin")) ?? false;
		}
	}
}