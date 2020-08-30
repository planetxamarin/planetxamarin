using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DenysFiediaiev : IAmACommunityMember
    {
        public string FirstName => "Denys";
        public string LastName => "Fiediaiev";
        public string StateOrRegion => "Ukraine";
        public string EmailAddress => "fiediaiev@sbyte.dev";
        public string ShortBioOrTagLine => "is a mobile developer specializing in Xamarin technology";
        public Uri WebSite => new Uri("https://medium.com/@prin53");
        public string TwitterHandle => "sbytedev";
        public string GitHubHandle => "Prin53";
        public string GravatarHash => "0d5df57543a53231787d7a34a9b79cd6";
        public IEnumerable<Uri> FeedUris => new[] {new Uri("https://medium.com/feed/@prin53")};
        public GeoPosition Position => new GeoPosition(50.4547, 30.5238);
        public string FeedLanguageCode => "en";
    }
}