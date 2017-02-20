using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class MarcosCobenaMorian
    {
        public string FirstName => "Marcos";
        public string LastName => "Cobeña Morián";
		public string ShortBioOrTagLine => "is a Senior Mobile Developer at DevsDNA";
        public string EmailAddress => "marcoscm.digital@gmail.com";
		public Uri WebSite => new Uri("http://marcoscobena.com");

		public string StateOrRegion => "Sevilla (Andalucía), Spain";
		public GeoPosition Position => new GeoPosition(37.3753501, -6.0250978);
        
		public string GitHubHandle => "MarcosCobena";
		public string TwitterHandle => "MarcosCobena_";

		public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://marcoscobena.com/feed-xamarin.xml"); } }
    }
}