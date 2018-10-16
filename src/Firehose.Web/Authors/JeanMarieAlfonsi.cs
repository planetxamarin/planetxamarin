using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JeanMarieAlfonsi : IAmACommunityMember
    {
        public string FirstName => "Jean-Marie";
        public string LastName => "Alfonsi";
        public string ShortBioOrTagLine => "is a singing software engineer who travels at the speed light and wanna make a supersonic man out of you.";
        public string StateOrRegion => "Paris, France";
        public string EmailAddress => "jm.alfonsi@gmail.com";
        public string TwitterHandle => "Piskariov";
        public string GravatarHash => "2a30d8bc59e2ccb6e83bb498d519394a";
        public Uri WebSite => new Uri("https://www.sharpnado.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.sharpnado.com/rss/"); }
        }

        public string GitHubHandle => "roubachof";
        public GeoPosition Position => new GeoPosition(48.8588377, 2.2770206);
        public string FeedLanguageCode => "en";
    }
}