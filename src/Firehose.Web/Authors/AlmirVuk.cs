using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{

    public class AlmirVuk : IAmACommunityMember
    {

        public string FirstName => "Almir";
        public string LastName => "Vuk";
        public string ShortBioOrTagLine => "is a Mobile and Web Developer, Microsoft Student Partner, .NET Enthusiast and speaker at local MS events";
        public string StateOrRegion => "Mostar, Bosnia and Herzegovina";
        public string EmailAddress => "almir.vuk@outlook.com";
        public string TwitterHandle => "almirvuk";
        public string GravatarHash => "d58b6fd6c2d9f949345e8d14d203a4b2";

        public Uri WebSite => new Uri("https://almirvuk.blogspot.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://almirvuk.blogspot.ba/feeds/posts/default?alt=rss"); } }

        public string GitHubHandle => "almirvuk";

        public GeoPosition Position => new GeoPosition(43.3395522, 17.7862211);
        public string FeedLanguageCode => "en";
    }
}