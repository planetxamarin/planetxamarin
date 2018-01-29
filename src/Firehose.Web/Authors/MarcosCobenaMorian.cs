using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class MarcosCobenaMorian
    {
        public string FirstName => "Marcos";
        public string LastName => "Cobeña Morián";
		public string ShortBioOrTagLine => "I write apps for people using Xamarin";
        public string EmailAddress => "marcoscm.digital@gmail.com";
		public Uri WebSite => new Uri("http://marcoscobena.com");

		public string StateOrRegion => "Sevilla (Andalucía), Spain";
		public GeoPosition Position => new GeoPosition(37.3753501, -6.0250978);
        
		public string GitHubHandle => "MarcosCobena";
		public string TwitterHandle => "1Marcos2Cobena";

        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://feeds.feedburner.com/MarcosCobena"); } }
    }
}