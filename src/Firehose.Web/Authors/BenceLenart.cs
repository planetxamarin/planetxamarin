using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class BenceLenart : IAmAMicrosoftMVP, IAmAXamarinMVP
    {
		public string FirstName => "Bence";
        public string LastName => "Lenart";
		public string StateOrRegion => "Szeged, Hungary";
		public string EmailAddress => "bence960206@gmail.com";
        public string ShortBioOrTagLine => "is working at Baseflow.com on Apps and MvvmCross";
		public Uri WebSite => new Uri("https://officialdoniald.azurewebsites.net");

        public IEnumerable<Uri> FeedUris
        {
			get { yield return new Uri("https://officialdoniald.azurewebsites.net/feed/"); }
        }

		public string TwitterHandle => "officialdoniald";
		public string GravatarHash => "4e467fcdbb65da5080d215bf303c442a";
		public string GitHubHandle => "officialdoniald";
		public GeoPosition Position => new GeoPosition(46.231217, 20.119176);
        public string FeedLanguageCode => "en";
    }
}
