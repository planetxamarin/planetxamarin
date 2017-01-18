using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GoneMobile : IAmACommunityMember
    {
        public string FirstName => "Gone";

        public string LastName => "Mobile";

        public string StateOrRegion => "Internet";

        public string EmailAddress => "gonemobilecast@gmail.com";

        public string ShortBioOrTagLine => "Podcast";

        public Uri WebSite => new Uri("http://gonemobile.io");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://feed.gonemobile.io"); }
        }

        public string TwitterHandle => "gonemobilecast";


        public string GravatarHash => "cb611c5ecd9a53b2af53a9d50d83c3c5";
        public string GitHubHandle => string.Empty;
    }
}