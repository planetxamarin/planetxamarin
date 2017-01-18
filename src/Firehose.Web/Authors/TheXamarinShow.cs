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

        public string EmailAddress => "planet@xamarin.com";

        public string ShortBioOrTagLine => "Weekly Developer Show";

        public Uri WebSite => new Uri("http://xamarinshow.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://channel9.msdn.com/Shows/XamarinShow/RSS"); }
        }

        public string TwitterHandle => "thexamarinshow";

        public string GravatarHash => "5db2c9a87693f1fd71f18df1e049b975";
    }
}
