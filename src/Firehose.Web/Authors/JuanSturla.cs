using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JuanSturla : IAmACommunityMember
    {
        public string FirstName => "Juan";
        public string LastName => "Sturla";
        public string StateOrRegion => "Rosario, Santa Fe, Argentina";
        public string EmailAddress => "jms0210@gmail.com";
        public string ShortBioOrTagLine => ".NET Mobile (Xamarin/MAUI) Developer";
        public Uri WebSite => new Uri("https://pollitosdemaui.wordpress.com/");
        public string TwitterHandle => "juan_sturla";
        public string GitHubHandle => "juansturla";
        public string GravatarHash => "910e916b6a8d98172d4d0ab5a4d7ba4b";

        public IEnumerable<Uri> FeedUris
        {
            get
            {
                return new Uri[]{
                    new Uri("https://pollitosdemaui.wordpress.com/category/net-maui/feed/"),
                    new Uri("https://mauichicken.wordpress.com/category/net-maui/feed/")
                };
            }
        }

        public GeoPosition Position => new GeoPosition(-32.947641123448165, -60.630455637128755);
        public string FeedLanguageCode => "es";
    }
}
