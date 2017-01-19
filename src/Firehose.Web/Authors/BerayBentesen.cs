using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
	public class BerayBentesen : IAmACommunityMember
	{
		public string FirstName => "Beray";
		public string LastName => "Bentesen";
		public string ShortBioOrTagLine => string.Empty;
		public string StateOrRegion => "Istanbul, Turkey";
		public string EmailAddress => "beraybentesen@windowslive.com";
		public string TwitterHandle => "BerayBentesen";
		public string GravatarHash => string.Empty;
		public string GitHubHandle => "beraybentesen";
		public GeoPosition Position => new GeoPosition(41.015137, 28.979530);

		public Uri WebSite => new Uri("http://www.code2xamarin.net/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://code2xamarin.net/rss/"); } }
	}
}
