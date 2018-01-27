using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SebastianJensen : IAmACommunityMember
    {
        public string FirstName => "Sebastian";
        public string LastName => "Jensen";
        public string StateOrRegion => "Pforzheim, Germany";
        public string EmailAddress => "apps@tsjdev-apps.de";
        public string ShortBioOrTagLine => "App Developer";
        public Uri WebSite => new Uri("https://blog.tsjdev-apps.de");
        public string TwitterHandle => "tsjdevapps";
        public string GitHubHandle => "tsjdev-apps";
        public string GravatarHash => "d990a05a189c263901ca94367d3a50be";
        public GeoPosition Position => new GeoPosition(48.892186, 8.694629);
        public bool Filter(SyndicationItem item) => item.Categories.Any(cat => cat.Name.ToLowerInvariant() == "xamarin");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.tsjdev-apps.de/feed"); }
        }
    }
}