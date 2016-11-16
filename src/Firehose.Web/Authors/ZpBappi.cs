using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ZpBappi : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Zp"; }
        }

        public string LastName
        {
            get { return "Bappi"; }
        }

        public string StateOrRegion
        {
            get { return "NSW"; }
        }

        public string EmailAddress
        {
            get { return "zpbappi@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Developer"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://zpbappi.com"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://zpbappi.com/feed"); }
        }

        public string TwitterHandle
        {
            get { return "zpbappi"; }
        }
    }
}