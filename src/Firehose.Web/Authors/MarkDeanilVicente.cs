using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarkDeanilVicente : IAmAMicrosoftMVP
    {
        public string FirstName => "Mark Deanil";
        public string LastName => "Vicente";
        public string StateOrRegion => "Manila, Philippines";
        public string EmailAddress => "markdeanilvicente@gmail.com";
        public string ShortBioOrTagLine => "is passionate programmer & a developer. Co-founder of Mobile .Net Developers - Philippines. He enjoys wine and hot tea";
        public Uri WebSite => new Uri("https://deanilvincent.github.io/");
        public string TwitterHandle => "DeanilVincent03";
        public string GitHubHandle => "deanilvincent";
        public string GravatarHash => "a90b830f123ffdcac52f8e16c8bcd829";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://deanilvincent.github.io/feed"); }
        }

        public GeoPosition Position => new GeoPosition(14.5547, 121.0244);
        public string FeedLanguageCode => "en";
    }
}