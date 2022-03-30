using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
	public class DaveMurray : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Dave";

		public string LastName => "Murray";

		public string StateOrRegion => "Scotland";

		public string EmailAddress => "murray.dave@outlook.com";

		public string ShortBioOrTagLine => "All I ask is an IDE and a star to steer her by...";

		public Uri WebSite => new Uri("https://blog.taranissoftware.com/");

		public string TwitterHandle => string.Empty;

		public string GitHubHandle => "irongut";

		public string GravatarHash => "74e244ccb7ef008d5eae1b109e23dc60";

		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://blog.taranissoftware.com/rss.xml"); } }

		public GeoPosition Position => new GeoPosition(55.860916, -4.251433);

		public string FeedLanguageCode => "en";

		public bool Filter(SyndicationItem item) => item.Title.Text.ToLowerInvariant().Contains("xamarin") || item.Title.Text.ToLowerInvariant().Contains("maui");
	}
}