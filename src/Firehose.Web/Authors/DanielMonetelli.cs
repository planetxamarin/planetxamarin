using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class DanielMonetelli : IAmACommunityMember
	{
		public string FirstName => "Daniel A.";

		public string LastName => "Monetelli L.";

		public string ShortBioOrTagLine => "Xamarin Mobile Developer / Software Engineer";

		public string StateOrRegion => "Arequipa - Perú";

		public string EmailAddress => "danielmonetelli@protonmail.com";

		public Uri WebSite => new Uri("https://danielmonetelli.azurewebsites.net/");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://danielmonetelli.azurewebsites.net/feed/"); }
		}

		public string TwitterHandle => "DanielMonetelli";


		public string GravatarHash => "4b3d0e60019ad8fe1e4d7cd5c8850efb";
		public string GitHubHandle => "monetelli";

		public GeoPosition Position => new GeoPosition(-16.406158351483526, -71.54764652252197);

        public string FeedLanguageCode => "es";
	}
}
