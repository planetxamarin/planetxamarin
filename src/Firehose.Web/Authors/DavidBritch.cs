using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class DavidBritch : IWorkAtXamarinOrMicrosoft
	{
		public string FirstName => "David";
		public string LastName => "Britch";
		public string Title => "Senior Developer/Writer";
		public string StateOrRegion => "UK";
		public string EmailAddress => "";
		public string TwitterHandle => "britchdavid";
		public string GravatarHash => "0ddca71a03a3591203b4a748fcdfb47a";
		public DateTime Started => new DateTime(2015, 06, 08);
		public string ShortBioOrTagLine => string.Empty;
		public string GitHubHandle => "davidbritch";
		public GeoPosition Position => new GeoPosition(53.479300, -2.247900);
		public Uri WebSite => new Uri("https://www.davidbritch.com");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://www.davidbritch.com/rss.xml"); }
		}

        public string FeedLanguageCode => "en";
	}
}