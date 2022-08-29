using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RobinManuelThiel : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Robin-Manuel";
        public string LastName => "Thiel";
        public string ShortBioOrTagLine => "Techie at Microsoft by day, tinker and fiddler by night. Loves everything with a power plug or IP address.";
        public string StateOrRegion => "Munich, Germany";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "robinmanuelt";
        public string GitHubHandle => "robinmanuelthiel";
        public GeoPosition Position => new GeoPosition(48.177622, 11.5912643);
        public Uri WebSite => new Uri("https://pumpingco.de/");
        public string GravatarHash => "1b8fabaa8d66250a7049bdb9ecf44397";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://pumpingco.de/feed/"); }
        }

        public string FeedLanguageCode => "en";
    }
}