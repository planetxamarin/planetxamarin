using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RichardTaylor : IAmACommunityMember
    {
        public string FirstName => "Richard";
        public string LastName => "Taylor";
        public string StateOrRegion => "Huntersville, NC";
        public string TwitterHandle => "rightincode";
        public string EmailAddress => "rtaylor@rightincode.com";
        public string ShortBioOrTagLine => "Husband, father, Microsoft MVP, and software dev with a passion for .Net, and doing software right. It's all about Right'in Code!";
        public string GravatarHash => "0d22251b18adde612a8434bdc9c486e4";
        public Uri WebSite => new Uri("https://rightincode.dev/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://rightincode.dev/syndication.axd"); }
        }

        public string GitHubHandle => "rightincode";

        public GeoPosition Position => new GeoPosition(35.402291, -80.888765);
        public string FeedLanguageCode => "en";
    }
}