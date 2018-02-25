using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarcoSiccardi : IAmACommunityMember
    {
        public string FirstName => "Marco";
        public string LastName => "Siccardi";
        public string ShortBioOrTagLine => "cross platform developer, writing software for Desktop, Mobiles and IOT";
        public string StateOrRegion => "Switzerland";
        public string EmailAddress => "msiccdev@hotmail.com";
        public string TwitterHandle => "msicc";
        public string GravatarHash => "67aaa7c3b6357dbccc1167a70b0c73e3";
        public string GitHubHandle => "msiccdev";
        public GeoPosition Position => new GeoPosition(47.4683, 8.75727);
        public Uri WebSite => new Uri("https://msicc.net/category/devstories/xamarin/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://msicc.net/category/devstories/xamarin/feed/"); } }
        public string FeedLanguageCode => "en";
    }
}