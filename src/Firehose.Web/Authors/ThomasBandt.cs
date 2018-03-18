using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ThomasBandt : IAmAMicrosoftMVP
    {
        public string FirstName => "Thomas";
        public string LastName => "Bandt";
        public string StateOrRegion => "Munich, Germany";
        public GeoPosition Position => new GeoPosition(48.1485869, 11.5353743);
        public string EmailAddress => string.Empty;
        public Uri WebSite => new Uri("https://thomasbandt.com/");
        public string ShortBioOrTagLine => "Developer & Entrepreneur of Passion";
        public string TwitterHandle => "asp_net";
        public string GitHubHandle => "aspnetde";
        public string GravatarHash => "32860557b42ace0afa72704e466e34f1";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://thomasbandt.com/feed"); }
        }

        public string FeedLanguageCode => "en";
    }
}