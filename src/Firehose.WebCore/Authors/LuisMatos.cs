using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class LuisMatos : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Luis";
        public string LastName => "Matos";
        public string StateOrRegion => "Dominican Republic";
        public string TwitterHandle => "luismatosluna";
        public string EmailAddress => "hello@luismts.com";
        public string ShortBioOrTagLine => "Software Engineer, Entrepreneur";
        public string GravatarHash => "ac9ac28f6b1e05a310d622b37e8bc4be";
        public Uri WebSite => new Uri("https://www.luismts.com/");

        public IEnumerable<Uri> FeedUris
        {
            get
            {
                yield return new Uri("https://www.luismts.com/feed/");
                yield return new Uri("https://www.luismts.com/es/feed/");
            }
        }

        public string GitHubHandle => "luismts";

        public GeoPosition Position => new GeoPosition(18.4900563, -69.8962411);

        public string FeedLanguageCode => "en";

		public bool Filter(SyndicationItem item)
		{
			var relevantToXamarin = false;

			if (item.Title.Text.ToLowerInvariant().Contains("xamarin"))
			{
				// If the title mentions Xamarin, the topic is primarily and directly relevant.
				relevantToXamarin = true;
			}
			else if (item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("xamarin")) ?? false)
			{
				// If the categories contains Xamarin, the topic directly relevant.
				relevantToXamarin = true;
			}

			return relevantToXamarin;
		}
	}
}
