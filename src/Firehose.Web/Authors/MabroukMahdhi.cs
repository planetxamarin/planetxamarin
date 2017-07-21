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

        public IEnumerable<Uri> FeedUris => new List<Uri>() { new Uri("http://xamabrouk.blogspot.de/rss.xml") };


        public string FirstName => "Mabrouk";


        public string GitHubHandle => "MabroukENG";


        public string GravatarHash => "1f5b179abb9b9f8a34a4a9799e205c96";


        public string LastName => "Mahdhi";

        public GeoPosition Position => new GeoPosition(49.022821, 12.162714);

        public string ShortBioOrTagLine => ", is a .Net & Xamarin apps developer @Gefasoft-Engineering GmbH";


        public string StateOrRegion => "Tegernheim, Bayern, Germany";


        public string TwitterHandle => "Mabrouk_MAHDHI";

        public Uri WebSite => new Uri("http://xamabrouk.blogspot.de/");
    }
}
