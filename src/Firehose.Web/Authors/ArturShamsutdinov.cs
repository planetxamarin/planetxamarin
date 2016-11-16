using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ArturShamsutdinov : IAmAReadifarian
    {
        public string FirstName => "Artur";

        public string LastName => "Shamsutdinov";

        public string StateOrRegion => "NSW";

        public string EmailAddress => "artur.shamsutdinov@readify.net";

        public string Title => "Senior Engineer";

        public Uri WebSite => new Uri("http://shamsutdinov.net/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://shamsutdinov.net/feed/"); }
        }

        public string TwitterHandle => "halkar";
    }
}
