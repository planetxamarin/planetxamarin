using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class SermetKose : IAmACommunityMember
	{
		public string FirstName => "Sermet";
		public string LastName => "Kose";
		public string StateOrRegion => "IST, Turkey";
		public string EmailAddress => "sermetkose@gmail.com";
		public string ShortBioOrTagLine => "is Software Developer at Apsiyon.";
		public Uri WebSite => new Uri("https://medium.com/sermet-blog");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://medium.com/feed/sermet-blog/tagged/P"); }
		}

		public string TwitterHandle => string.Empty;
		public string GravatarHash => "5f0f99eb2cb09d1591079198f43418b9";
		public string GitHubHandle => "sermetk";
		public GeoPosition Position => new GeoPosition(41.0055005, 28.7319902);
		public string FeedLanguageCode => "en";
	}
}
