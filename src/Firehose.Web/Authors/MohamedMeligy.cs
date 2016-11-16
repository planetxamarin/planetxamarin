using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MohamedMeligy : IAmAReadifarian
    {
        public string FirstName
        {
            get { return "Mohamed"; }
        }

        public string LastName
        {
            get { return "Meligy"; }
        }

        public string StateOrRegion
        {
            get { return "NSW"; }
        }

        public string EmailAddress
        {
            get { return "mohamed.meligy@readify.net"; }
        }

        public string Title
        {
            get { return "Senior Consultant"; }
        }

        public Uri WebSite
        {
            get { return new Uri("http://gurustop.net/"); }
        }

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://gurustop.net/feed"); }
        }

        public string TwitterHandle
        {
            get { return "Meligy"; }
        }
    }
}