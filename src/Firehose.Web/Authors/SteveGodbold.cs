using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SteveGodbold : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Steve"; }
        }

        public string LastName
        {
            get { return "Godbold"; }
        }

        public string StateOrRegion
        {
            get { return "VIC"; }
        }

        public string EmailAddress
        {
            get { return "stephen.godbold@readify.net"; }
        }

        public string Title
        {
            get { return "Marketing Director"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://stevegodbold.com/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://stevegodbold.wordpress.com/feed/"); }
        }

        public string TwitterHandle
        {
            get { return "SteveGodbold"; }
        }
    }
}
