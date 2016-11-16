using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RichardBanks : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Richard"; }
        }

        public string LastName
        {
            get { return "Banks"; }
        }

        public string StateOrRegion
        {
            get { return "NSW"; }
        }

        public string EmailAddress
        {
            get { return "richard.banks@readify.net"; }
        }

        public string Title
        {
            get { return "Principal Consultant"; }
        }

        public Uri WebSite
        {
            get { return new Uri("https://www.richard-banks.org/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.richard-banks.org/feed.xml"); }
        }

        public string TwitterHandle
        {
            get { return "rbanks54"; }
        }
    }
}