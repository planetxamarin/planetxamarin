using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class JesseJiang : IAmACommunityMember
    {
        public string FirstName => "Jesse";

        public string LastName => "Jiang";

        public string StateOrRegion => "Sydney, Australia";

        public string ShortBioOrTagLine => "😄";

        public string EmailAddress => "jessejiang0214@outlook.com";

        public Uri WebSite => new Uri("https://jessejiang.xyz/");

        public string TwitterHandle => "jessejiang0214";

        public string GitHubHandle => "jessejiang0214";

        public string GravatarHash => "4781a2f2472557b9749e0a8bcbed935b";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://jessejiang.xyz/feed/"); }
        }

        public GeoPosition Position => new GeoPosition(-33.8718094, 151.2057269);

        public string FeedLanguageCode => "en";
    }
}