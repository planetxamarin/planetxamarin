using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class TheXamarinShow : IAmACommunityMember
    {
        public string FirstName => "The Xamarin";

        public string LastName => "Show";

        public string StateOrRegion => "Channel 9";

        public string EmailAddress => "";

        public string ShortBioOrTagLine => "Weekly Developer Show for Xamarin Developers";

        public Uri WebSite => new Uri("http://xamarinshow.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://s.ch9.ms/Shows/XamarinShow/feed"); }
        }

        public string TwitterHandle => "thexamarinshow";

        public string GravatarHash => "7a0c7da0279b4e90439e780fa01924e0";
    }
}
