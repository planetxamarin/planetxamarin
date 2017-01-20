using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Firehose.Web.Authors
{
    public class MabroukMahdhi : IAmACommunityMember
    {
        public string EmailAddress => "mabrouk@mahdhi.com";

        public IEnumerable<Uri> FeedUris => new List<Uri>();


        public string FirstName => "Mabrouk";


        public string GitHubHandle => "MabroukENG";


        public string GravatarHash => "";


        public string LastName => "Mahdhi";

        public GeoPosition Position => new GeoPosition(35.772390, 10.825278);

        public string ShortBioOrTagLine => ".Net & Xamarin apps developer";


        public string StateOrRegion => "Monastir";


        public string TwitterHandle => "Mabrouk_MAHDHI";

        public Uri WebSite => new Uri("http://mahdhi.com/");
    }
}
