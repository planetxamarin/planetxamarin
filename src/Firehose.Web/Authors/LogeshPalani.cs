using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class LogeshPalani : IAmACommunityMember
    {
        public string FirstName => "Logesh";

        public string LastName => "Palani";

        public string StateOrRegion => "Thiruvannamalai,Tamil Nadu,  India";

        public string EmailAddress => "logesh.01@hotmail.com";

        public string ShortBioOrTagLine => "Keep Learning,.. and Keep Practicing,...";

        public Uri WebSite => new Uri("https://logeshpalani.blogspot.com/");

        public string TwitterHandle => "logeshpalani98";

        public string GitHubHandle => "logeshpalani98";

        public string GravatarHash => "14fd9ec21509b468c84abbed2e47384e";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://logeshpalani.blogspot.com/feeds/posts/default"); }
        }

        public GeoPosition Position => new GeoPosition(12.527056, 79.098382);

        public string FeedLanguageCode => "en";
    }
}