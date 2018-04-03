using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DayaneLima : IAmACommunityMember
    {
        public string FirstName => "Dayane";
        public string LastName => "Lima";
        public string StateOrRegion => "Contagem, Brasil";
        public string TwitterHandle => "";
        public string GitHubHandle => "dayaneLima";
        public string ShortBioOrTagLine => "Mobile developer";
        public string EmailAddress => "dayane.lima.castro@gmail.com";
        public string GravatarHash => "ffe92dc239b85204e4fbba7e93982b0f";
        public GeoPosition Position => new GeoPosition(-19.9386, -44.0529);
        public Uri WebSite => new Uri("https://www.portalxamarin.com.br");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.portalxamarin.com.br/feed/"); }
        }

        public string FeedLanguageCode => "pt";
    }
}