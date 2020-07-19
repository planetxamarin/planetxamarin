using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class AlexShirshov : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Alex";
		public string LastName => "Shirshov";
		public string StateOrRegion => "Sydney, Australia";
		public string EmailAddress => "shirshov@gmail.com";
		public string ShortBioOrTagLine => "Software Craftsman";
		public Uri WebSite => new Uri("https://omnitalented.com");
		public string TwitterHandle => "omnitalented";
		public string GitHubHandle => "shirshov";
		public string GravatarHash => "";
		public GeoPosition Position  => new GeoPosition(-33.882360, 151.206588);
		public string FeedLanguageCode => "en";
		// This is a special feed URL, with Xamarin related posts only
		public IEnumerable<Uri> FeedUris => new[] {new Uri("https://omnitalented.com/rss-xamarin.xml")};
		public bool Filter(SyndicationItem item) => true;
	}
}