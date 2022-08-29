using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
	public class DivikiranRavela : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Divikiran";

		public string LastName => "Ravela";

		public string StateOrRegion => "Melbourne, Australia";

		public string EmailAddress => "divikiran1@gmail.com";

		public string ShortBioOrTagLine => "Xamarin Consultant/Tech Lead";

		public Uri WebSite => new Uri("https://xamlabs.com/");

		public string TwitterHandle => "";

		public string GitHubHandle => "divikiran";

		public string GravatarHash => "";

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://xamlabs.com/feed/"); }
		}

		public GeoPosition Position => new GeoPosition(-37.8135511,144.9637748);

		public string FeedLanguageCode => "en";

		public bool Filter(SyndicationItem item)
		{
			return item.Title.Text.ToLowerInvariant().Contains("xamarin");
		}
	}
}
