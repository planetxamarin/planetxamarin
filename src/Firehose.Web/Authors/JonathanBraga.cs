using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Firehose.Web.Authors
{
    public class JonathanBraga : IAmACommunityMember
    {
        public string FirstName => "Jonathan";
        public string LastName => "Braga";
        public string ShortBioOrTagLine => "is a mobile developer | community enthusiast | technology enthusiast.";
        public string EmailAddress => "jonathanb2br@gmail.com";
        public string TwitterHandle => "__jonathan_";
        public string GravatarHash => "e5d5252f73093a20de005c51d1a701db";
        public string StateOrRegion => "Rio Grande do Norte, Brasil";
        public Uri WebSite => new Uri("http://jonathanbraga.github.io");
        public string GitHubHandle => "jonathanbraga";
        public GeoPosition Position => new GeoPosition(-5.874660, -35.215132);

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://jonathanbraga.com/feed.xml"); }
        }
    }
}