using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class JeromeGiacomini : IAmACommunityMember
    {
        public string FirstName => "Jérôme";

        public string LastName => "Giacomini";

        public string StateOrRegion => "Paris, France";

        public string EmailAddress => "jerome.giacomini@gmail.com";

        public string ShortBioOrTagLine => "is a Xamarin Enthusiast, co-author of a book on Xamarin";

        public Uri WebSite => new Uri("https://jeromegiacomini.net/Blog/");

        public string TwitterHandle => "jeromegiacomini";

        public string GitHubHandle => "jgiacomini";

        public string GravatarHash => "95e63961669a22586a1236fd6a7a494d";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://jeromegiacomini.net/Blog/feed/"); }
        }

        public GeoPosition Position => new GeoPosition(48.8704842, 2.3449646);

        public string FeedLanguageCode => "fr";
    }
}