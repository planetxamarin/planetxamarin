using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class AnbuMani : IAmACommunityMember
	{
		public string FirstName => "Anbu";
		public string LastName => "Mani";
		public string ShortBioOrTagLine => "is a Microsoft MVP who Blogger, Speaker, Founder & Organizer of XMonkeys360 Community – India.";
		public string EmailAddress => "anbumani@xmonkeys360.com";
		public string TwitterHandle => "anbu_mani27";
		public string GravatarHash => "f97650474e4aa5b9609a28dcfdb052d4";
		public string StateOrRegion => "Chennai, India";
		public Uri WebSite => new Uri("https://www.xmonkeys360.com/");
		public GeoPosition Position => new GeoPosition(12.902749, 80.190846);

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://xmonkeys360.com/feed/"); }
		}

		public string GitHubHandle => "AnbuMani27";
		public string FeedLanguageCode => "en";
	}
}