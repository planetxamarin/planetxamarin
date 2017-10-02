using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class TimKlingeleers : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Tim";

		public string LastName => "Klingeleers";

		public string StateOrRegion => "Heusden-Zolder, Belgium";

		public string EmailAddress => "tim@klingeleers.be";

		public string ShortBioOrTagLine => "is a mobile and web developer, developing Xamarin apps at APG";

		public Uri WebSite => new Uri("https://tim.klingeleers.be/");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://tim.klingeleers.be/feed/"); }
		}

		public string TwitterHandle => "TimKlingeleers";

		public string GravatarHash => "7efbe9aa7d1ae58ec900e23d32a5f365";

		public string GitHubHandle => "Mardaneus86";

		public GeoPosition Position => new GeoPosition(51.009389, 5.304912);

		public bool Filter(SyndicationItem item)
		{
			return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
		}
	}
}