using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AndrewHoefling : IAmACommunityMember
    {
        public string FirstName => "Andrew";
        public string LastName => "Hoefling";
        public string StateOrRegion => "New York, United States";
        public string EmailAddress => "andrew@hoefling.me";
        public string ShortBioOrTagLine => "Open Source developer who loves integrating Xamarin with other platforms";
        public Uri WebSite => new Uri("https://www.andrewhoefling.com/");
        public string TwitterHandle => "andrew_hoefling";
        public string GitHubHandle => "ahoefling";
        public string GravatarHash => "beab68478a5128e634590af5e4f01941";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.andrewhoefling.com/feed.xml?category=xamarin"); }
        }
        public GeoPosition Position => new GeoPosition(43.156578, -77.608849);
        public string FeedLanguageCode => "en";
    }
}
