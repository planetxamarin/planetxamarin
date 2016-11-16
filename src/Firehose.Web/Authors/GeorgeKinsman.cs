using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GeorgeKinsman : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "George"; }
        }

        public string LastName
        {
            get { return "Kinsman"; }
        }

        public string StateOrRegion
        {
            get { return "QLD"; }
        }

        public string EmailAddress
        {
            get { return "george.kinsman@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Developer"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://georgekinsman.com"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://georgekinsman.com/feed.xml"); }
        }
            
        public string TwitterHandle
        {
            get { return "georgekinsman"; }
        }
    }
}