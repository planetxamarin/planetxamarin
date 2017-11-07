using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class WeeklyXamarin : IAmACommunityMember, IAmANewsletter
    {
        public string FirstName => "Weekly";

        public string LastName => "Xamarin";

        public string StateOrRegion => "Internet";

        public string EmailAddress => "inbox@weeklyxamarin.com";

        public string ShortBioOrTagLine
            =>
                "is a weekly newsletter that contains a hand-picked round-up of the best mobile development links and resources. Curated by Geoffrey Huntley. Free."
        ;

        public Uri WebSite => new Uri("https://www.weeklyxamarin.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://weeklyxamarin.com/issues.rss"); }
        }

        public string TwitterHandle => "weeklyxamarin";

        public string GitHubHandle => string.Empty;

        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(-22.9791499, 133.0190863);
    }
}
