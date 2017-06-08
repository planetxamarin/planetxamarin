using System;
using System.Collections.Generic;
using System.Web;
using Firehose.Web.Infrastructure;
using System.ServiceModel.Syndication;
using System.Linq;

namespace Firehose.Web.Authors
{
    public class DevlinDuldulao : IAmACommunityMember
    {
        public string FirstName => "Devlin";
        public string LastName => "Duldulao";
        public string StateOrRegion => "Q.C., Manila, Philippines";
        public string ShortBioOrTagLine => "is a Xamarin developer and instructor.";
        public string GitHubHandle => "webmasterdevlin";
        public string TwitterHandle => "DevlinDuldulao";
        public string EmailAddress => "devlinduldulao@outlook.com";
        public string GravatarHash => "7ba002fce5d57d93bc1109bcffeedc21";
        public Uri WebSite => new Uri("http://devlinduldulao.pro/");
        public GeoPosition Position => new GeoPosition(14.6839502, 120.9921632);
        
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://devlinduldulao.pro/feed/"); }
        }
    }
}
