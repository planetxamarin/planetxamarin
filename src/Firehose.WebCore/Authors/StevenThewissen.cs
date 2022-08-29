using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class StevenThewissen : IAmACommunityMember
    {
        public string FirstName => "Steven";
        public string LastName => "Thewissen";
        public string StateOrRegion => "The Netherlands";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => " is a Xamarin Developer with a knack for Photoshop and a passion for soccer and cycling. He is also in love with his Xbox One";
        public Uri WebSite => new Uri("https://www.thewissen.io/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.thewissen.io/feed/"); }
        }

        public string TwitterHandle => "devnl";
        public string GravatarHash => "9f698e6f515cb54dbda305034b6823fc";
        public GeoPosition Position => new GeoPosition(50.889039, 5.853717);
        public string GitHubHandle => "sthewissen";
        public string FeedLanguageCode => "en";
    }
}