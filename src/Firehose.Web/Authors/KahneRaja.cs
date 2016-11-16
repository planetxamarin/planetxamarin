using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KahneRaja : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Kahne"; }
        }

        public string LastName
        {
            get { return "Raja"; }
        }

        public string StateOrRegion
        {
            get { return "NSW"; }
        }

        public string EmailAddress
        {
            get { return "Kahne.Raja@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Developer"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://www.KahneRaja.com/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.KahneRaja.com/feed"); }
        }

        public string TwitterHandle
        {
            get { return "KahneRaja"; }
        }
    }
}
