using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AdamPatridge : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Adam";
        public string LastName => "Patridge";
        public string StateOrRegion => "Cheyenne, WY";
        public string TwitterHandle => "patridgedev";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => string.Empty;
        public string GravatarHash => "29f7fb03af5c354d6098f0300114056b";
        public Uri WebSite => new Uri("https://www.patridgedev.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.patridgedev.com/feed/"); }
        }

        public string GitHubHandle => "patridge";

        public GeoPosition Position => new GeoPosition(41.1399810, -104.8202460);

        public string FeedLanguageCode => "en";
    }
}
