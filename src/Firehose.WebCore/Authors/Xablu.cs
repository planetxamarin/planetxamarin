using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class Xablu : IAmACommunityMember
    {
        public string FirstName => "Xablu";
        public string LastName => "";
        public string StateOrRegion => "Amsterdam, the Netherlands";
        public string EmailAddress => "hello@xablu.com";
        public string ShortBioOrTagLine => "a 100% pure Xamarin company.";
        public Uri WebSite => new Uri("https://www.xablu.com/");
        public string TwitterHandle => "xabluhq";
        public string GitHubHandle => "xablu";
        public string GravatarHash => "508b1a99bb81e09c189e7487ecb69167";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.xablu.com/tag/planet-xamarin/feed/"); }
        }

        public GeoPosition Position => new GeoPosition(52.3702, 4.8952);
        public string FeedLanguageCode => "en";
    }
}
