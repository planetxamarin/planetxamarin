using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarcBruins : IAmACommunityMember
    {
        public string FirstName => "Marc";
        public string LastName => "Bruins";
        public string ShortBioOrTagLine => "is a native iOS/Android developer who fell in love with Xamarin";
        public string EmailAddress => "marc@marcbruins.nl";
        public string TwitterHandle => "MarcBruins";
        public string GravatarHash => "3795d2031be87499f76f6336ec5a3a45";
        public string StateOrRegion => "Utrecht, Netherlands";
        public Uri WebSite => new Uri("https://www.marcbruins.nl");
        public string GitHubHandle => "MarcBruins";
        public GeoPosition Position => new GeoPosition(53.2193840, 6.5665020);

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.marcbruins.nl/feed.xml"); }
        }

        public string FeedLanguageCode => "en";
    }
}