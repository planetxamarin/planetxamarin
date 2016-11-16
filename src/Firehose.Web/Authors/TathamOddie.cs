using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class TathamOddie : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Tatham"; }
        }

        public string LastName
        {
            get { return "Oddie"; }
        }

        public string StateOrRegion
        {
            get { return "VIC"; }
        }

        public string EmailAddress
        {
            get { return "tatham.oddie@readify.net"; }
        }

        public string Title
        {
            get { return "CIO"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://tath.am/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://blog.tatham.oddie.com.au/feed/"); }
        }

        public string TwitterHandle
        {
            get { return "tathamoddie"; }
        }
    }
}
