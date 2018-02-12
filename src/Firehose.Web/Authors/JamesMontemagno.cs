using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JamesMontemagno : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "James";
        public string LastName => "Montemagno";
        public string StateOrRegion => "Seattle, WA";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => "is a Principal Program Manager for Mobile Developer Tools";
        public Uri WebSite => new Uri("https://montemagno.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://montemagno.com/rss"); }
        }

        public string TwitterHandle => "JamesMontemagno";
        public string GravatarHash => "5df4d86308e585c879c19e5f909d8bfe";
        public string GitHubHandle => "jamesmontemagno";
        public GeoPosition Position => new GeoPosition(47.6541770, -122.3500000);
        public string FeedLanguageCode => "en";
    }
}