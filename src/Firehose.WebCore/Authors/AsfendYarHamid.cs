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

        public string ShortBioOrTagLine => "is a Technical Trainer, Author at Udemy and Passionate Community Member as well as Software Engineer";

        public Uri WebSite => new Uri("https://xamarinui.blogspot.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://xamarinui.blogspot.com/feeds/posts/default"); }
        }

        public string TwitterHandle => "asfend";

        public string GravatarHash => "1aa9a7436eec5ad5d0418a385d1bdbe0";
        public string GitHubHandle => "asfend";
        public GeoPosition Position => new GeoPosition(31.5712, 74.3646);
        public string FeedLanguageCode => "en";
    }
}