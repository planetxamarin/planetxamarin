using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ChrisWilliams : IAmACommunityMember
    {
        public string FirstName => "Chris";
        public string LastName => "Williams";
        public string ShortBioOrTagLine => string.Empty;
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "crswlls";
        public string GravatarHash => "21e379df7ba9c57f167188e2fcb7dd75";
        public string StateOrRegion => "Bristol, UK";
        public Uri WebSite => new Uri("https://crswlls.wordpress.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://crswlls.wordpress.com/rss/"); }
        }

        public string GitHubHandle => string.Empty;
        public GeoPosition Position => new GeoPosition(30.2671530, -97.7430610);
        public string FeedLanguageCode => "en";
    }
}