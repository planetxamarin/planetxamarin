using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GeraldVersluis : IAmAMicrosoftMVP
    {
        public string FirstName => "Gerald";

        public string LastName => "Versluis";

        public string StateOrRegion => "Holland";

        public string EmailAddress => "";

        public string ShortBioOrTagLine => string.Empty;

        public Uri WebSite => new Uri("https://blog.verslu.is/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.verslu.is/feed/"); }
        }

        public string TwitterHandle => "jfversluis";

        public string GravatarHash => "f9d4d4211d7956ce3e07e83df0889731";
        public string GitHubHandle => string.Empty;
        public GeoPosition Position => new GeoPosition(52.1326330, 5.2912660);
    }
}