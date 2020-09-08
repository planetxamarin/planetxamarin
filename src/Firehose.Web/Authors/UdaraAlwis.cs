using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class UdaraAlwis : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Udara";
		public string LastName => "Alwis";
		public string ShortBioOrTagLine => "A mobile dev enthusiast. Xamarin Certified Developer in Singapore.";
		public string StateOrRegion => "Singapore";
		public string EmailAddress => "udara.robotics@gmail.com";
		public string TwitterHandle => "Udara_Alwis";
		public string GravatarHash => "125c4aaed98f2a88207dac78c17dd344";
		public string GitHubHandle => "UdaraAlwis";
		public GeoPosition Position => new GeoPosition(1.284433, 103.859609);
		public Uri WebSite => new Uri("https://theconfuzedsourcecode.wordpress.com/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://theconfuzedsourcecode.wordpress.com/feed/"); } }
		public string FeedLanguageCode => "en";

		public bool Filter(SyndicationItem item)
		{
			// This filters out only the posts that have the "xamarin" category
			// Not all blog posts have categories, please guard against this
			return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("xamarin")) ?? false;
		}
	}
}