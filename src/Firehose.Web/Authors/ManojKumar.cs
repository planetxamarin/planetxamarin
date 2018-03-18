using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class ManojKumar : IAmACommunityMember
    {
        public string FirstName => "Manoj";

        public string LastName => "Kumar";

        public string StateOrRegion => "Punjab, India";

        public string EmailAddress => "manojkg@live.com";

        public string ShortBioOrTagLine => "Xamarin for Moblity Cloud and IoT";

        public Uri WebSite => new Uri("https://manicoder.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://manicoder.com/feed/"); }
        }

        public string TwitterHandle => "manicoder1";

        public string GravatarHash => "628f49b37266ba84659c68d8270d803d";
        public string GitHubHandle => "manicoder";
        public GeoPosition Position => new GeoPosition(30.877484, 75.872832);

        public string FeedLanguageCode => "en";
    }
}