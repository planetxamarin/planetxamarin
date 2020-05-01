using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class PeterFoot : IAmAMicrosoftMVP
	{
		public string FirstName => "Peter";
		public string LastName => "Foot";
		public string StateOrRegion => "United Kingdom";
		public string EmailAddress => "peter@peterfoot.net";
		public string TwitterHandle => "peterfoot";
		public Uri WebSite => new Uri("https://inthehand.com/blog/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://inthehand.com/category/xamarin/feed/"); } }
		public string GravatarHash => "fa15aeeccc4b23e8a4677aeacb65b7bb";
        public string ShortBioOrTagLine => "develops Xamarin and Windows applications at In The Hand Ltd";
        public string GitHubHandle => "peterfoot";
        public GeoPosition Position => new GeoPosition(52.76872, -2.37825);
        public string FeedLanguageCode => "en";
	}
}
