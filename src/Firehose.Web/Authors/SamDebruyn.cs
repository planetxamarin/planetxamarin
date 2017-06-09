using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class SamDebruyn : IAmACommunityMember
    {
        public string FirstName => "Sam";

        public string LastName => "Debruyn";

        public string StateOrRegion => "Hallaar, Belgium";

        public string EmailAddress => "s@muel.be";

        public string ShortBioOrTagLine => "is a Xamarin developer by day and an all-round code ninja by night.";

        public Uri WebSite => new Uri("https://chipsncookies.com");

        public string TwitterHandle => "SamuelDebruyn";

        public string GitHubHandle => "SamuelDebruyn";

        public string GravatarHash => "0dca14faf3538b3ebba29b7c2e03cf8f";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://chipsncookies.com/tags/xamarin/index.xml"); }
        }

        public GeoPosition Position => new GeoPosition(51.086, 4.732);
    }
}