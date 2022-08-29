using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class MikolajKieres : IAmACommunityMember
	{
		public string EmailAddress => "mikolaj.kieres@progrunning.net";

		public string FeedLanguageCode => "en";

		public IEnumerable<Uri> FeedUris
		{
			get
			{
				yield return new Uri("https://progrunning.net/rss/");
			}
		}

		public string FirstName => "Mikolaj";

		public string GitHubHandle => "mkieres";

		public string GravatarHash => "";

		public string LastName => "Kieres";

		public GeoPosition Position => new GeoPosition(-33.826623, 151.195031);

		public string ShortBioOrTagLine => "Mobile development adventurer";

		public string StateOrRegion => "Sydney, Australia";

		public string TwitterHandle => "mikolajkieres";

		public Uri WebSite => new Uri("https://progrunning.net");
	}
}