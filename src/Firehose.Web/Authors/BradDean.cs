using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{

	public class BradDean : IAmACommunityMember
	{

		public string FirstName => "Brad";

		public string LastName => "Dean";

		public string ShortBioOrTagLine => "is a Xamarin mobile developer";

		public string StateOrRegion => "Atlanta";

		public string EmailAddress => "brad@truegeek.com";

		public string TwitterHandle => "BradDeanDev";

		public string GravatarHash => "990a708aaacb12fc6882eb45b4a26ffd";

		public string GitHubHandle => "TrueGeek";

		public GeoPosition Position => new GeoPosition(33.955002, -83.988251);

		public Uri WebSite => new Uri("https://truegeek.com");

		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://truegeek.com/feed.xml"); } }

        public string FeedLanguageCode => "en";

	}

}
