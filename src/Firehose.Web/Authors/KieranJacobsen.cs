using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KieranJacobsen : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Kieran"; }
        }

        public string LastName
        {
            get { return "Jacobsen"; }
        }

        public string StateOrRegion
        {
            get { return "VIC"; }
        }

        public string EmailAddress
        {
            get { return "kieran.jacobsen@readify.net"; }
        }

        public string Title
        {
            get { return "Technical Lead"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://www.poshsecurity.com/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.poshsecurity.com/blog/rss.xml"); }
        }

        public string TwitterHandle
        {
            get { return "kjacobsen"; }
        }
    }
}
