using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class BenceLenart : IAmACommunityMember
	{
		public string FirstName => "Bence";

		public string LastName => "Lenart";

		public string ShortBioOrTagLine => "Xamarin developer and blogger.";

		public string StateOrRegion => "Szeged, Hungary";

		public string EmailAddress => "bence960206@gmail.com";

		public Uri WebSite => new Uri("https://officialdoniald.com");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://officialdoniald.com/feed"); }
		}

		public string TwitterHandle => "officialdoniald";


		public string GravatarHash => "4e467fcdbb65da5080d215bf303c442a";
		public string GitHubHandle => "officialdoniald";

		public GeoPosition Position => new GeoPosition(46.231222, 20.119167);

        public string FeedLanguageCode => "en";
	}
}
