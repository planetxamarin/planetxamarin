using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class LuisMatos : IAmACommunityMember
    {
        public string FirstName => "Luis";
        public string LastName => "Matos";
        public string StateOrRegion => "Dominican Republic";
        public string TwitterHandle => "luismatosluna";
        public string EmailAddress => "hello@luismts.com";
        public string ShortBioOrTagLine => "Software Engineer, Entrepreneur";
        public string GravatarHash => "ac9ac28f6b1e05a310d622b37e8bc4be";
        public Uri WebSite => new Uri("https://www.luismts.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.luismts.com/feed/"); }
        }

        public string GitHubHandle => "luismts";
        public GeoPosition Position => new GeoPosition(18.4900563, -69.8962411);
        public string FeedLanguageCode => "en";
    }
}
