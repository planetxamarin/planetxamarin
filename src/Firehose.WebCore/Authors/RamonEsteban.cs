using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RamonEsteban : IAmACommunityMember
	{
		public string FirstName => "Ramon";
		public string LastName => "Esteban";
		public string ShortBioOrTagLine => "Freelance Xamarin developer";
		public string StateOrRegion => "Malaga, Spain";
		public string EmailAddress => "wantedforcode@outlook.com";
		public string TwitterHandle => "ramonesteban78";
		public string GravatarHash => "2fc49c3e9095aece416ad4e147fa1452";
		public string GitHubHandle => "ramonesteban78";
		public GeoPosition Position => new GeoPosition(36.5126395, -4.6483388);
		public Uri WebSite => new Uri("https://ramonesteban78.github.io/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://ramonesteban78.github.io/feed.xml"); } }
        public string FeedLanguageCode => "es";
	}
}