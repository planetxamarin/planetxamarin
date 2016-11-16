using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MohamedZaatar : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Mohamed"; }
        }

        public string LastName
        {
            get { return "Zaatar"; }
        }

        public string StateOrRegion
        {
            get { return "WA"; }
        }

        public string EmailAddress
        {
            get { return "mohamed.zaatar@readify.net"; }
        }

        public string Title
        {
            get { return "Software Developer"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://mzaatar.com"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://mzaatar.com/feed"); }
        }

        public string TwitterHandle
        {
            get { return "mzaatar"; }
        }
    }
}