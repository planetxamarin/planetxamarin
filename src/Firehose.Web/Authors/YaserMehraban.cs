using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class YaserMehraban : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Yaser"; }
        }

        public string LastName
        {
            get { return "Mehraban"; }
        }

        public string StateOrRegion
        {
            get { return "VIC"; }
        }

        public string EmailAddress
        {
            get { return "yaser.mehraban@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Developer"; }
        }

        public Uri WebSite
        {
            get { return new Uri("https://www.mehraban.com.au/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://blog.mehraban.com.au/feed"); }
        }

        public string TwitterHandle
        {
            get { return "yaser_mehraban"; }
        }
    }
}
