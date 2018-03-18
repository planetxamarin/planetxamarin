using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class StefanDeVogelaere : IAmACommunityMember
    {
        public string FirstName => "Stefan";
        public string GitHubHandle => "stefandevo";
        public string LastName => "de Vogelaere";
        public string ShortBioOrTagLine => "";
        public string StateOrRegion => "Wommelgem, Belgium";
        public string EmailAddress => "stefan.de.vogelaere@gmail.com";
        public string TwitterHandle => "stefandevo";
        public Uri WebSite => new Uri("https://stefandevo.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://stefandevo.com/feed/"); }
        }

        public string GravatarHash => "c91dbad10c922f0fef71e9e2df15b763";
        public GeoPosition Position => new GeoPosition(51.2021680, 4.5219650);
        public string FeedLanguageCode => "en";
    }
}