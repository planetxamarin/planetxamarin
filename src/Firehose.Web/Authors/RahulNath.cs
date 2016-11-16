using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class RahulNath : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Rahul"; }
        }

        public string LastName
        {
            get { return "Nath"; }
        }

        public string StateOrRegion
        {
            get { return "NSW"; }
        }

        public string EmailAddress
        {
            get { return "rahul.nath@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Consultant"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://www.rahulpnath.com"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://feeds2.feedburner.com/rahulpnath"); }
        }

        public string TwitterHandle
        {
            get { return "rahulpnath"; }
        }
    }
}