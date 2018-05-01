using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DevlinDuldulao : IAmACommunityMember
    {
        public string FirstName => "Devlin";
        public string LastName => "Duldulao";
        public string ShortBioOrTagLine => "Xamarin certified, a trainer, a speaker";
        public string StateOrRegion => "Manila";
        public string EmailAddress => "webmasterdevlin@gmail.com";
        public string TwitterHandle => "DevlinDuldulao";
        public string GitHubHandle => "webmasterdevlin";
        public string GravatarHash => "7dc408ee2ccfa6fb9eac30cdf08926bf";
        public GeoPosition Position => new GeoPosition(14.6841162, 120.9921632);
        public Uri WebSite => new Uri("https://devlinduldulao.pro/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://devlinduldulao.pro/feed/"); } }
        public string FeedLanguageCode => "en";
    }
}