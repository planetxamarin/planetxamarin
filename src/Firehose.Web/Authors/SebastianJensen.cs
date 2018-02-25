using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SebastianJensen : IAmACommunityMember
    {
        public string FirstName => "Sebastian";
        public string LastName => "Jensen";
        public string StateOrRegion => "Pforzheim, Germany";
        public string EmailAddress => "apps@tsjdev-apps.de";
        public string ShortBioOrTagLine => "is Mobile .NET Developer and creates apps for UWP, iOS and Android.";
        public Uri WebSite => new Uri("https://www.tsjdev-apps.de");
        public string TwitterHandle => "tsjdevapps";
        public string GitHubHandle => "tsjdev-apps";
        public string GravatarHash => "d990a05a189c263901ca94367d3a50be";
        public GeoPosition Position => new GeoPosition(48.892186, 8.694629);

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.tsjdev-apps.de/feed"); }
        }

        public string FeedLanguageCode => "de";
    }
}