using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AlessandroCaliaro : IAmACommunityMember
    {
        public string FirstName => "Alessandro";
        public string LastName => "Caliaro";
        public string ShortBioOrTagLine => "I like Xamarin Forms and I like help other people to understand it";
        public string EmailAddress => "acaliaro@libero.it";
        public string TwitterHandle => "acaliaro";
        public string GravatarHash => "a7466eb1c467806f77bc692a4745d0f9";
        public string StateOrRegion => "Lissone, Italy";
        public Uri WebSite => new Uri("https://acaliaro.wordpress.com");
        public string GitHubHandle => "acaliaro";
        public GeoPosition Position => new GeoPosition(45.6327830, 9.2272650);

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://acaliaro.wordpress.com/feed/"); }
        }

        public string FeedLanguageCode => "en";
    }
}