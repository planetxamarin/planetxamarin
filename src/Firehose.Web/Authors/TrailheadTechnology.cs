using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class TrailheadTechnology : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Trailhead Technology";
        public string LastName => "";
        public string StateOrRegion => "Jenison, MI";
        public string TwitterHandle => "@TrailheadTec";
        public string EmailAddress => "info@trailheadtechnology.com";
        public string ShortBioOrTagLine => string.Empty;
        public string GravatarHash => "0d6c200b64336790495f110332e1d7be";
        public Uri WebSite => new Uri("https://www.trailheadtechnology.com/");

        public IEnumerable<Uri> FeedUris
        {
            get
            {
               return new List<Uri>()
               {
                 new Uri("https://trailheadtechnology.com/feed")
               };
            }
        }

        public string GitHubHandle => "trailheadtechnology";

        public GeoPosition Position => new GeoPosition(
42.921436, -85.806578);

        public string FeedLanguageCode => "en";
    }
}
