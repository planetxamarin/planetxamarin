using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
    public class TomSoderling : IAmACommunityMember
    {
        public string FirstName => "Tom";
        public string LastName => "Soderling";
        public string StateOrRegion => "MPLS";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => string.Empty;
        public string TwitterHandle => "tomsoderlng";
        public string GravatarHash => "dd103f377899fc63b0b88c5bb62b15bd";

        public Uri WebSite => new Uri("https://mobilecomposer.github.io");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://mobilecomposer.github.io/feed.xml"); }
        }

        public string GitHubHandle => string.Empty;
    }
}