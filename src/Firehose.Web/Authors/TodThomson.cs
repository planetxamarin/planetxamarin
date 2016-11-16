using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class TodThomson : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Tod"; }
        }

        public string LastName
        {
            get { return "Thomson"; }
        }

        public string StateOrRegion
        {
            get { return "QLD"; }
        }

        public string EmailAddress
        {
            get { return "tod.thomson@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Consultant"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://todthomson.com"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://todthomson.com/feed.xml"); }
        }

        public string TwitterHandle
        {
            get { return "todthomson"; }
        }
    }
}