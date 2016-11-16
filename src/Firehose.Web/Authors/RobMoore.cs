using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RobMoore : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Robert"; }
        }

        public string LastName
        {
            get { return "Moore"; }
        }

        public string StateOrRegion
        {
            get { return "WA"; }
        }

        public string EmailAddress
        {
            get { return "rob.moore@readify.net"; }
        }

        public string Title
        {
            get { return "Principal Consultant"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://robdmoore.id.au/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://robdmoore.id.au/feed/"); }
        }

        public string TwitterHandle
        {
            get { return "robdmoore"; }
        }
    }
}
