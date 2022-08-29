using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{

    public class AlmirVuk : IAmACommunityMember, IAmAMicrosoftMVP
    {
        public string FirstName => "Almir";
        public string LastName => "Vuk";
        public string ShortBioOrTagLine => "Software Development Engineer & Microsoft MVP, crafting apps with ASP.NET Core and Xamarin";
        public string StateOrRegion => "Mostar, Bosnia and Herzegovina";
        public string EmailAddress => "almir.vuk@outlook.com";
        public string TwitterHandle => "almirvuk";
        public string GravatarHash => "d58b6fd6c2d9f949345e8d14d203a4b2";

        public Uri WebSite => new Uri("https://almirvuk.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://almirvuk.com/rss/"); } }

        public string GitHubHandle => "almirvuk";

        public GeoPosition Position => new GeoPosition(43.3395522, 17.7862211);
        public string FeedLanguageCode => "en";
    }
}