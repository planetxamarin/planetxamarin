using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
	public class VijayAnandEG : IAmACommunityMember
	{
		public string FirstName => "Vijay Anand";

		public string LastName => "E G";

		public string StateOrRegion => "Chennai, Tamil Nadu, India";

		public string EmailAddress => "egvijayanand@outlook.com";

		public string ShortBioOrTagLine => "passionate software professional working on .NET";

		public Uri WebSite => new Uri("https://egvijayanand.in/");

		public string TwitterHandle => "egvijayanand";

		public string GitHubHandle => "egvijayanand";

		public string GravatarHash => "60f1549aa56354c8b770040db12a23f8";

		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://egvijayanand.in/feed/"); } }

		public GeoPosition Position => new GeoPosition(12.986768, 80.2117061);

		public string FeedLanguageCode => "en";
	}
}
