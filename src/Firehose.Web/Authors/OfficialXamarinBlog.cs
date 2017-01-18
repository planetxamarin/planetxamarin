using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class OfficialXamarinBlog : IAmACommunityMember
    {
        public string FirstName => "Xamarin";

        public string LastName => "Blog";

        public string StateOrRegion => "Internet";

        public string EmailAddress => "hello@xamarin.com";

        public string ShortBioOrTagLine => "Official Blog";

        public Uri WebSite => new Uri("http://blog.xamarin.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://blog.xamarin.com/feed/"); }
        }

        public string TwitterHandle => "xamarinhq";


        public string GravatarHash => "70148d964bb389d42547834e1062c886";
    }
}
