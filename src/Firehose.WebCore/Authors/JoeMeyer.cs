using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JoeMeyer : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Joe";
		public string LastName => "Meyer";
		public string StateOrRegion => "Chicago, IL";
		public string TwitterHandle => "iwritecodesmtms";
		public string EmailAddress => "joseph.w.meyer@live.com";
		public string ShortBioOrTagLine => "I write code sometimes";
		public string GravatarHash => "1431dd2c4749b0a178c7a3130e71831e";
		public Uri WebSite => new Uri("https://iwritecodesometimes.net");
		public string GitHubHandle => "JoeM-RP";
		public GeoPosition Position => new GeoPosition(41.92, -87.65);

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://iwritecodesometimes.net/feed/"); }
		}

        public string FeedLanguageCode => "en";

		public bool Filter(SyndicationItem item)
			=> item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("xamarin")) ?? false;
	}
}