using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class RahulRai : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Rahul"; }
        }

        public string LastName
        {
            get { return "Rai"; }
        }

        public string StateOrRegion
        {
            get { return "NSW"; }
        }

        public string EmailAddress
        {
            get { return "rahul.rai@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Developer"; }
        }

        public Uri WebSite
        {
            get { return new Uri("https://rahulrai.in"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://rahulrai.in/post/index.xml"); }
        }

        public string TwitterHandle
        {
            get { return "moonytheloony"; }
        }
    }
}