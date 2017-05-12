using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AsfendYarHamid : IAmACommunityMember
    {
        public string FirstName => "Asfend Yar";

        public string LastName => "Hamid";

        public string StateOrRegion => "Lahore, Pakistan";

        public string EmailAddress => "asfend@hotmail.com";

        public string ShortBioOrTagLine => "Passionate Software Engineer.";

        public Uri WebSite => new Uri("https://xamarinui.blogspot.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://xamarinui.blogspot.com/feeds/posts/default"); }
        }

        public string TwitterHandle => "asfend";

        public string GravatarHash => "";
        public string GitHubHandle => "asfend";
        public GeoPosition Position => new GeoPosition(31.5712, 74.3646);
    }
}
