using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class GoneMobile : IAmACommunityMember
    {
        public string FirstName => "Gone";

        public string LastName => "Mobile";

        public string StateOrRegion => "Internet";

        public string EmailAddress => "gonemobilecast@gmail.com";

        public string Title => "Podcast";

        public Uri WebSite => new Uri("http://gonemobile.io");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://feed.gonemobile.io"); }
        }

        public string TwitterHandle => "gonemobilecast";


        public string GravatarHash => "cb611c5ecd9a53b2af53a9d50d83c3c5";
    }
}