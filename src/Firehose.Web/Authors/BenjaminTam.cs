using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class BenjaminTam : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Benjamin"; }
        }

        public string LastName
        {
            get { return "Tam"; }
        }

        public string StateOrRegion
        {
            get { return "NSW"; }
        }

        public string EmailAddress
        {
            get { return "benjamin.tam@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Developer"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://www.teamtam.net/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://teamtam.net/feed/"); }
        }

        public string TwitterHandle
        {
            get { return "benjamintam"; }
        }
    }
}
