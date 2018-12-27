using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class DanielMonetelli : IAmACommunityMember
	{
		public string FirstName => "Daniel";

		public string LastName => "Monetelli";

		public string ShortBioOrTagLine => "Daniel Monetelli is a Xamarin Developer, UI/UX Architect";

		public string StateOrRegion => "Arequipa - Perú";

		public string EmailAddress => "danielmonetelli@hotmail.com";

		public Uri WebSite => new Uri("https://danielmonetelli.azurewebsites.net/");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://danielmonetelli.azurewebsites.net/feed/"); }
		}

		public string TwitterHandle => "DanielMonetelli";


		public string GravatarHash => "4b3d0e60019ad8fe1e4d7cd5c8850efb";
		public string GitHubHandle => "monetelli";

		public GeoPosition Position => new GeoPosition(-16.4042643 , -71.5486383);

    public string FeedLanguageCode => "es";
	}
}
