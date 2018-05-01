using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class HussainAbbasi : IAmACommunityMember
    {
        public string FirstName => "Hussain";

        public string LastName => "Abbasi";

        public string StateOrRegion => "Houston, Texas";

        public string EmailAddress => "hnabbasi@outlook.com";

        public string ShortBioOrTagLine => "is a Blogger, Mobile Architect, and founder of intelliAbb.com. More at HussainAbbasi.com";

        public Uri WebSite => new Uri("https://www.intelliabb.com/");

        public string TwitterHandle => "HussainNAbbasi";

        public string GitHubHandle => "hnabbasi";

        public string GravatarHash => "6f415af725ae2d6b5b912a7e93b105b9";

        public IEnumerable<Uri> FeedUris => new List<Uri> {
            new Uri("https://www.intelliabb.com/feed")
        };

        public GeoPosition Position => new GeoPosition(29.7656, -95.3681);

        public string FeedLanguageCode => "en";
    }
}
