using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JacobDuijzer : IAmACommunityMember
    {
        public string FirstName => "Jacob";

        public string LastName => "Duijzer";

        public string StateOrRegion => "Vught, Netherlands";

        public string EmailAddress => "jacob@duijzer.com";

        public string ShortBioOrTagLine => "is a software developer, mainly writing code in .NET and  Xamarin apps";

        public Uri WebSite => new Uri("https://blog.duijzer.com");

        public string TwitterHandle => "jacobduijzer";

        public string GitHubHandle => "jacobduijzer";

        public string GravatarHash => "30727f633c533177e24b46379083c0d4";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.duijzer.com/index.xml"); }
        }

        public GeoPosition Position => new GeoPosition(51.6520909, 5.2432168);

        public string FeedLanguageCode => "en";
    }
}
