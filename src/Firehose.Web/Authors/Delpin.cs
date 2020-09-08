using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class Delpin : IAmACommunityMember
    {
        public string FirstName => "Delpin";

        public string LastName => "Susai Raj";

        public string StateOrRegion => "Chennai, India";

        public string EmailAddress => "susairajs@outlook.com";

        public string ShortBioOrTagLine => "Code with Monkeys";

        public Uri WebSite => new Uri("https://xamarinmonkeys.blogspot.com/");

        public string TwitterHandle => "susairajs18";

        public string GitHubHandle => "susairajs";

        public string GravatarHash => "3408967b9598e7bb107baf15d5a15454";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://xamarinmonkeys.blogspot.com/feeds/posts/default"); }
        }

        public GeoPosition Position => new GeoPosition(13.0783995, 80.2886684);

        public string FeedLanguageCode => "en";
    }
}