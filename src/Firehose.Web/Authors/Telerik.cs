using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class Telerik : IAmACommunityMember
	{
		public string FirstName => "Telerik";

		public string LastName => string.Empty;

		public string StateOrRegion => "Global";

		public string EmailAddress => "telerikxamarinteam@progress.com";

		public string ShortBioOrTagLine => "Progress Telerik UI libraries equip .NET ninjas with a full arsenal of weapons to help you create beautiful, modern and future-proof applications quickly and intuitively.";

		public Uri WebSite => new Uri("https://www.telerik.com/");

		public string TwitterHandle => "telerik";

		public string GitHubHandle => "telerik";

		public string GravatarHash => string.Empty;

		public IEnumerable<Uri> FeedUris
		{
			get
			{
				yield return new Uri("https://feeds.telerik.com/blogs");
			}
		}

		// Bedford, MA Headquarters.
		public GeoPosition Position => new GeoPosition(42.512778, -71.251500); 

		public string FeedLanguageCode => "en";
	}
}
