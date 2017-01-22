using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class NicolasMilcoff : IAmACommunityMember
    {
        public string FirstName => "Nicolas";

        public string LastName => "Milcoff";

        public string StateOrRegion => "Rosario, Argentina";

        public string EmailAddress => "nicolas.milcoff@d-genix.com";

        public string ShortBioOrTagLine => Mobile lead developer;

        public Uri WebSite => new Uri("http://nmilcoff.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://nmilcoff.com/feed/"); }
        }

        public string TwitterHandle => "nmilcoff";

        public string GravatarHash => "a689293f9c38aecdf729583533665e4a";

        public string GitHubHandle => nmilcoff;
        public GeoPosition Position => new GeoPosition(-32.945689, -60.642421);
    }
}
