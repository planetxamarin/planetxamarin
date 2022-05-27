using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Firehose.Web.Authors
{
	public class GokhanDogru : IAmACommunityMember
	{
		public string FirstName => "Gökhan";
		public string LastName => "Doğru";
		public string ShortBioOrTagLine => "Full Stack Developer & .NET/Open Source Lover ♥";
		public string StateOrRegion => "Izmir, Turkiye";
		public string EmailAddress => "info@gokhandogru.net";
		public string TwitterHandle => "dxgokhan";
		public string GravatarHash => "b98dab78c2bd524099ea4796c9550589";
		public string GitHubHandle => "dgokhan";
		public GeoPosition Position => new GeoPosition(38.38282156986651, 27.177658160244484);
		public Uri WebSite => new Uri("https://www.gokhandogru.net/#about-me");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://gokhandogru.net/feed"); }
		}

		public string FeedLanguageCode => "tr";
	}
}