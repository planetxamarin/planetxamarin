using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class MikeGrant : IAmACommunityMember
	{
		public string FirstName => "Mike";
		public string LastName => "Grant";
		public string StateOrRegion => "Leicestershire, England";
		public string EmailAddress => "";
		public string ShortBioOrTagLine => "Software Engineer";
		public Uri WebSite => new Uri("https://www.mikegrant.org.uk");
		public string GravatarHash => "06c34ad3fb10ef6786a043c4522b6a5b";

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://mikegrant.org.uk/feeds/Xamarin.Forms.xml"); }
		}
		public string TwitterHandle => "mike_grant_";
		public string GitHubHandle => "mike-grant";

		public GeoPosition Position => new GeoPosition(52.663878, -1.3052377);
		public string FeedLanguageCode => "en";
	}
}