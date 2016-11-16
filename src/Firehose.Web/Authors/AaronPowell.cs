using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AaronPowell : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Aaron"; }
        }

        public string LastName
        {
            get { return "Powell"; }
        }

        public string StateOrRegion
        {
            get { return "NSW"; }
        }

        public string EmailAddress
        {
            get { return "aaron.powell@readify.net"; }
        }

        public string Title
        {
            get { return "Principal Consultant"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://www.aaron-powell.com/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.aaron-powell.com/feed"); }
        }

        public string TwitterHandle
        {
            get { return "slace"; }
        }
    }
}
