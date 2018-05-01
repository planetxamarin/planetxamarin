using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MartynWiggins : IAmACommunityMember
	{
		public string FirstName => "Martyn";
		public string LastName => "Wiggins";
		public string ShortBioOrTagLine => "Mobile Developer, Mountain Biker, Wannabe Adventurer";
		public string StateOrRegion => "Nottingham";
		public string EmailAddress => "Martynnw@gmail.com";
		public string TwitterHandle => "Martynnw";
		public string GravatarHash => "bf974dae53bdbf5018fbbbf928db0f4e";
		public string GitHubHandle => "Martynnw";
		public GeoPosition Position => new GeoPosition(52.95, -1.133333);
		public Uri WebSite => new Uri("https://martynnw.wordpress.com");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://martynnw.wordpress.com/feed/"); } }
        public string FeedLanguageCode => "en";
    }
}