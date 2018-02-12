using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class TomSoderling : IAmACommunityMember
    {
        public string FirstName => "Tom";
        public string LastName => "Soderling";
        public string StateOrRegion => "Minneapolis, MN";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => "is a Sr. Mobile Developer, speaker, and open source contributor";
        public string TwitterHandle => "tomsoderling";
        public string GravatarHash => "dd103f377899fc63b0b88c5bb62b15bd";
        public GeoPosition Position => new GeoPosition(44.986656, -93.258133);
        public Uri WebSite => new Uri("https://tomsoderling.github.io");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://tomsoderling.github.io/feed.xml"); }
        }

        public string GitHubHandle => "TomSoderling";
        public string FeedLanguageCode => "en";
    }
}