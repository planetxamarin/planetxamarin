using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MartinZikmund : IAmACommunityMember
    {
        public string FirstName => "Martin";

        public string LastName => "Zikmund";

        public string StateOrRegion => "Prague, Czech Republic";

        public string EmailAddress => "martinzikmund@sphereline.com";

        public string ShortBioOrTagLine => "is a mobile + cloud solutions developer, Microsoftie, Geocacher, regular squash player, foodie and Insanity & P90X fan";

        public Uri WebSite => new Uri("https://blog.mzikmund.com/", UriKind.Absolute);

        public string TwitterHandle => "MZetko";

        public string GitHubHandle => "MartinZikmund";

        public string GravatarHash => "d1a45c7ba013fbc3e9044ff6461f6acd";

        public GeoPosition Position => new GeoPosition(50.124017, 14.451934);

        public string FeedLanguageCode => "en";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.mzikmund.com/feed/?lang=en_us"); }
        }
    }
}