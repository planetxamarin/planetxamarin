using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ThiagoBertuzzi : IAmACommunityMember
    {
        public string FirstName => "Thiago";
        public string LastName => "Bertuzzi";
        public string ShortBioOrTagLine => "Web and Mobile Developer, Blogger, Speaker";
        public string StateOrRegion => "São Paulo, Brasil";
        public string EmailAddress => "thiago.bertuzzi@gmail.com";
        public string TwitterHandle => "tbertuzzi";
        public string GitHubHandle => "tbertuzzi";
        public string GravatarHash => "82d95125be475913cdc7a7fe319d0133";
        public GeoPosition Position => new GeoPosition(-23.5834337, -46.6672048);
        public Uri WebSite => new Uri("https://medium.com/@bertuzzi/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://medium.com/feed/@bertuzzi"); } }
        public string FeedLanguageCode => "pt";
    }
}