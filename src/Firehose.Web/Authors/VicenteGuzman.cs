using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class VicenteGuzman : IAmACommunityMember
	{
		public string FirstName => "Vicente";

		public string LastName => "Guzman";

		public string ShortBioOrTagLine => "Vicente Guzman is a Community Member / Microsoft rMVP / Software Engineer";

		public string StateOrRegion => "Ciudad de México";

		public string EmailAddress => "luciomsp@geeks.ms";

		public Uri WebSite => new Uri("https://vicenteguzman.mx/");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://vicenteguzman.mx/feed/"); }
		}

		public string TwitterHandle => "luciomsp";


		public string GravatarHash => "72cce778aac0d6066a14225e90c30874";
		public string GitHubHandle => "VicenteGuzman";

		public GeoPosition Position => new GeoPosition(19.432608, -99.133209);

        public string FeedLanguageCode => "es";
	}
}