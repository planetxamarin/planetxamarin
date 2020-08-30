using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class AhmedFouad : IAmACommunityMember 
	{
		public string FirstName => "Ahmed";

		public string LastName => "Fouad";

		public string StateOrRegion => "Vienna, Austria";

		public string EmailAddress => "ahmed.fouad.net@hotmail.com";

		public string ShortBioOrTagLine => "software engineer with 10 years experience with the .NET Framework living in Vienna, Austria.";

		public Uri WebSite => new Uri("https://itnext.com/@csharpwriter");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://medium.com/feed/@csharpwriter"); }
		}

		public string TwitterHandle => "MCC_Ahmed";

		public string GravatarHash => "5727eb3df565991947d90ed140962472";
		public string GitHubHandle => "TheFo2sh";
		public GeoPosition Position => new GeoPosition(48.20849, 16.37208);

		public string FeedLanguageCode => "en";
	
	}

}
