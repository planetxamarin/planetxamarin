using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class LiamMclennan : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Liam"; }
        }

        public string LastName
        {
            get { return "Mclennan"; }
        }

        public string StateOrRegion
        {
            get { return "QLD"; }
        }

        public string EmailAddress
        {
            get { return "liam.mclennan@readify.net"; }
        }

        public string Title
        {
            get { return "Delivery Manager"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://withouttheloop.com/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://withouttheloop.com/feed.xml"); }
        }

        public string TwitterHandle
        {
            get { return "liammclennan"; }
        }
    }
}