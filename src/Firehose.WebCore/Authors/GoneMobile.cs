using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class GoneMobile : IAmACommunityMember, IAmAPodcast
    {
        public string FirstName => "Gone";

        public string LastName => "Mobile";

        public string StateOrRegion => "Internet";

        public string EmailAddress => "hello@gonemobile.io";

        public string ShortBioOrTagLine => "is a development podcast focused on mobile development hosted by Jon Dick and Greg Shackles.";

        // TEMPORARY WORKAROUND - We'll get https support shortly, for now we have it for the feed at least
        public Uri WebSite => new Uri("http://gonemobile.io");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://feed.gonemobile.io/"); }
        }

        public string TwitterHandle => "gonemobilecast";

        public GeoPosition Position => new GeoPosition(51.2537750, -85.3232140);

        public string GravatarHash => "cb611c5ecd9a53b2af53a9d50d83c3c5";

        public string GitHubHandle => string.Empty;

        public string FeedLanguageCode => "en";
    }
}