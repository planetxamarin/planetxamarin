using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class LeomarisReyes : IAmACommunityMember
    {
        public string FirstName => "Leomaris";

        public string LastName => "Reyes";

        public string StateOrRegion => "Santo Domingo";

        public string EmailAddress => "reyes.leomaris@gmail.com";

        public string ShortBioOrTagLine => ".NET Developer";

        public Uri WebSite => new Uri("https://askxammy.com");

        public string TwitterHandle => "LeomarisReyes11";

        public string GitHubHandle => "LeomarisReyes";

        public string GravatarHash => "ae78e84a683611c7b72c9ba829c125e0";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://askxammy.com/rss"); }
        }

		public GeoPosition Position => new GeoPosition(18.472209, -69.915665);

        public string FeedLanguageCode => "en";
    }
}
