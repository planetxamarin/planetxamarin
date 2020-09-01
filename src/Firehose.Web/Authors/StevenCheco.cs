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

		public string ShortBioOrTagLine => "is a C# ASP.Net and Xamarin Developer, I'd preferd back-end but I get along with the Front-End, I love help others with code and build new things with friends, I ♥ C#";

		public Uri WebSite => new Uri("https://checox.com");

		public string TwitterHandle => "steven1909";

		public string GitHubHandle => "sact1909";

		public string GravatarHash => "47ad7178de588bb9a0b5922a5c1364c8";

		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://checox.com/feed/"); } }

		public GeoPosition Position => new GeoPosition(40.837222, -73.886111);

		public string FeedLanguageCode => "en";

	}
}