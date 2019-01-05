using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class Martz : IAmACommunityMember
    {
        public string FirstName => "Martz";
        public string LastName => "";
        public string StateOrRegion => "Europe";
        public string TwitterHandle => "martz2804";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => string.Empty;
        public string GravatarHash => "b5d00fd00b366a1d846bfebaebffbd08";
        public Uri WebSite => new Uri("https://mfkl.github.io/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://mfkl.github.io/feed"); }
        }

        public string GitHubHandle => "mfkl";

        public GeoPosition Position => new GeoPosition(48.864716, 2.349014);

        public string FeedLanguageCode => "en";
    }
}