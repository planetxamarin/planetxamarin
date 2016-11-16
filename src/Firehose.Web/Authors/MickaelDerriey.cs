using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MickaelDerriey : IAmAReadifarian
    {
        public string EmailAddress => "mickael.derriey@readify.net";
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://mderriey.github.io/atom.xml"); } }
        public string FirstName => "Mickaël";
        public string LastName => "Derriey";
        public string StateOrRegion => "NSW";
        public string Title => "Senior Developer";
        public string TwitterHandle => "mderriey";
        public Uri WebSite => new Uri("https://mderriey.github.io/");
    }
}