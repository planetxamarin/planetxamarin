using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DomRaniszewski : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Dom"; }
        }

        public string LastName
        {
            get { return "Raniszewski"; }
        }

        public string StateOrRegion
        {
            get { return "NSW"; }
        }

        public string EmailAddress
        {
            get { return "dominik.raniszewski@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Consultant"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://devblog.xyz/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://devblog.xyz/feed"); }
        }

        public string TwitterHandle
        {
            get { return "DominikRan"; }
        }
    }
}
