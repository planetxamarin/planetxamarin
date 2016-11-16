using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MattHilton : IAmAReadifarian
    {
        public string FirstName => "Matt";
        public string LastName => "Hilton";
        public string Title => "Technical Talent Scout";
        public string StateOrRegion => "VIC";
        public string EmailAddress => "matt.hilton@readify.net";
        public string TwitterHandle => "mjhilton_";
        
        public Uri WebSite => new Uri("https://www.mjhilton.net/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.mjhilton.net/rss"); } }
    }
}
