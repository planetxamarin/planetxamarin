using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class SamirGC : IAmACommunityMember
	{
		public string FirstName => "Samir";

		public string LastName => "GC";

		public string ShortBioOrTagLine => ".net lover, xamarin mobile developer | XamarinGuy Show Host | Trainer | Instructor";

		public string StateOrRegion => "Kathmandu/Nepal";

		public string EmailAddress => "samirgcofficial@gmail.com";

		public string TwitterHandle => "xamaringuy";

		public string GitHubHandle => "samirgcofficial";

		public GeoPosition Position => new GeoPosition(27.700769, 85.300140);

		public Uri WebSite => new Uri("https://xamaringuyshow.com/");

		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://xamaringuyshow.com/feed/"); } }

		public string GravatarHash => "4b0b695b7711b0184ab2049e33f2cfd7";

		public string FeedLanguageCode => "en";
	}
}
