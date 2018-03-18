using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class MarioGalvan : IAmACommunityMember
	{
		public string FirstName => "Mario";
		public string LastName => "Galvan";
		public string ShortBioOrTagLine => "Mexican Mobile Developer and Xamarin enthusiast!";
		public string StateOrRegion => "Zapopan, Mexico";
		public string EmailAddress => "15mgm15@gmail.com";
		public Uri WebSite => new Uri("https://15mgm15.ghost.io/");
		public string TwitterHandle => "MayitoGalvan";
		public string GravatarHash => "048b59cb93b83e0d2a48f1e36b788932";
		public string GitHubHandle => "15mgm15";
		public GeoPosition Position => new GeoPosition(20.6024900, -103.4469050);

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://15mgm15.ghost.io/rss/"); }
		}

        public string FeedLanguageCode => "en";
	}
}