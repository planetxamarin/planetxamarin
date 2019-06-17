using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class KodjoLaurentEgbakou : IAmACommunityMember
    {
        public string FirstName => "Kodjo Laurent";
        public string LastName => "Egbakou";
        public string StateOrRegion => "Lome, Togo";
        public string EmailAddress => "laurent@lioncoding.com";
        public string ShortBioOrTagLine => "is C#/.Net/Xamarin developer who learns and shares.";
        public Uri WebSite => new Uri("https://lioncoding.com/");
        public string TwitterHandle => "lioncoding";
        public string GitHubHandle => "egbakou";
        public string GravatarHash => "6e26a030d3b9495872b58d922bd86157";
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://lioncoding.com/feed.xml"); } }
        public GeoPosition Position => new GeoPosition(6.2030129, 1.1918434);
        public string FeedLanguageCode => "fr";
    }
}