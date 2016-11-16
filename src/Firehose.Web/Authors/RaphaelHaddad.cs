using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RaphaelHaddad : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Raphael"; }
        }

        public string LastName
        {
            get { return "Haddad"; }
        }

        public string StateOrRegion
        {
            get { return "NSW"; }
        }

        public string EmailAddress
        {
            get { return "raphael.haddad@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Developer"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://www.raph.ws/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.raph.ws/feeds/posts/default"); }
        }

        public string TwitterHandle
        {
            get { return "RaphHaddadAus"; }
        }
    }
}
