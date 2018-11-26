using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class LeomarisReyes : IAmACommunityMember
    {
        public string FirstName => "Leomaris";

        public string LastName => "Reyes";

        public string StateOrRegion => "Santo Domingo, DN";

        public string EmailAddress => "reyes.leomaris@gmail.com";

        public string ShortBioOrTagLine => "I am a software developer";

        public Uri WebSite => new Uri("https://askxammy.com");

        public string TwitterHandle => "leomarisreyes11";

        public string GitHubHandle => "leomarisreyes";

        public string GravatarHash => "ae78e84a683611c7b72c9ba829c125e0";

        public IEnumerable<Uri> FeedUris => new Uri[]{ new Uri("https://askxammy.com/feed") };

        public GeoPosition Position => new GeoPosition(18.473273, -69.913012);

        public string FeedLanguageCode => "en";
    }
}
