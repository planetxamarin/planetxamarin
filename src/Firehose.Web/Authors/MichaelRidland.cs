using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class MichaelRidland : IAmAXamarinMVP
    {
        public string FirstName => "Michael";

        public string LastName => "Ridland";

        public string StateOrRegion => "Sydney, Australia";

        public string EmailAddress => "michael@xam-consulting.com";

        public string Title => "director of an Xamarin consultancy";

        public Uri WebSite => new Uri("http://www.michaelridland.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.michaelridland.com/feed/"); }
        }

        public string TwitterHandle => "rid00z";

        public DateTime FirstAwarded => new DateTime(2015, 4, 1);

        public string GravatarHash => "";
    }
}
