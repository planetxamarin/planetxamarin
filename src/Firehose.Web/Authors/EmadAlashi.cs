using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class EmadAlashi : IAmAReadifarian
    {
        public string FirstName 
        {
            get { return "Emad"; }
        }

        public string LastName
        {
            get { return "Alashi"; }
        }

        public string StateOrRegion
        {
            get { return "VIC"; }
        }

        public string EmailAddress
        {
            get { return "emad.alashi@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Consultant"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://emadashi.com"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://emadashi.com/feed"); }
        }

        public string TwitterHandle
        {
            get { return "emadashi"; }
        }
    }
}