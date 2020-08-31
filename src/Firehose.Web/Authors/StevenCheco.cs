using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Firehose.Web.Authors
{
	public class StevenCheco : IAmACommunityMember
	{
		public string FirstName => "Steven";

		public string LastName => "Checo";

		public string StateOrRegion => "United States";

		public string EmailAddress => "steven.checo.19@gmail.com";

		public string ShortBioOrTagLine => "Software Engineer";

		public Uri WebSite => new Uri("https://checox.com");

		public string TwitterHandle => "steven1909";

		public string GitHubHandle => "sact1909";

		public string GravatarHash => "47ad7178de588bb9a0b5922a5c1364c8";

		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://checox.com/feed"); } }

		public GeoPosition Position => new GeoPosition(40.8448, 73.8648);

		public string FeedLanguageCode => "Es";

	}
}