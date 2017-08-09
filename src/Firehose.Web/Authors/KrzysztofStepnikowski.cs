using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
	public class KrzysztofStepnikowski : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Krzysztof";

		public string LastName => "Stępnikowski";

		public string StateOrRegion => "Rzeszów, Poland";

		public string EmailAddress => "skrzychu7@gmail.com";

		public string ShortBioOrTagLine => "Focused on mobile world. Passionate about Xamarin, Android and new technologies.";

		public Uri WebSite => new Uri("https://krzysztofstepnikowski.wordpress.com/");

		public string GitHubHandle => "krzysztofstepnikowski";

		public string GravatarHash => "d90961e12e285b799b452398425a9905";

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://krzysztofstepnikowski.wordpress.com/feed/"); }
		}

		public GeoPosition Position => new GeoPosition(50.041142, 21.998410);
		
		public bool Filter(SyndicationItem item)
		{
			return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
		}
	}
}