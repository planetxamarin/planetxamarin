using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class EvgenyZborovsky : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Evgeny";

		public string LastName => "Zborovsky";

		public string StateOrRegion => "Estonia";

		public string EmailAddress => "";

		public string ShortBioOrTagLine => "Xamarin Enthusiast";

		public Uri WebSite => new Uri("https://smellyc0de.blogspot.com/");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://smellyc0de.blogspot.com/feeds/posts/default"); }
		}

		public string TwitterHandle => "ezborovsky";

		public string GravatarHash => "b8a0ab8445fafb38afdf26cb976df32f";
		public string GitHubHandle => "yuv4ik";

		public GeoPosition Position => new GeoPosition(58.3750372, 26.6625567);

		public bool Filter(SyndicationItem item) =>
		 	item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
			item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
	}
}
