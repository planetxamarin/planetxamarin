using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class BryanAnthonyGarcia : IAmACommunityMember
    {
        public string FirstName => "Bryan Anthony";
        public string LastName => "Garcia";
        public string StateOrRegion => "Manila, Philippines";
        public string GitHubHandle => "mindofai";
        public string TwitterHandle => "mindofai";
        public string EmailAddress => "bryananthonygarcia@live.com";
        public string ShortBioOrTagLine => "Mobile .NET Developer who enjoys learning and writing about Mobile .NET stuff and has passion for football. Co-leads Mobile .NET Developers - Philippines";
        public string GravatarHash => "29e1cdab06c48322805220e33556c20c";
        public Uri WebSite => new Uri("https://mindofai.github.io/");
        public GeoPosition Position => new GeoPosition(14.668896, 120.947204);
        
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://mindofai.github.io/feed.xml"); }
        }

        public string FeedLanguageCode => "en";
    }
}