using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class FraserPerkins : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Fraser"; }
        }

        public string LastName
        {
            get { return "Perkins"; }
        }

        public string StateOrRegion
        {
            get { return "VIC"; }
        }

        public string EmailAddress
        {
            get { return "fraser.perkins@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Developer"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://www.fraserperkins.com/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.fraserperkins.com/rss"); }
        }

        public string TwitterHandle
        {
            get { return "perkof"; }
        }
    }
}
