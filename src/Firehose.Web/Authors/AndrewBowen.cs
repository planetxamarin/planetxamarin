using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AndrewBowen : IAmAReadifarian
    {
        public string FirstName => "Andrew";

        public string LastName => "Bowen";

        public string StateOrRegion => "NSW";

        public string EmailAddress => "andrew.bowen@readify.net";

        public string Title => "Senior Consultant";

        public Uri WebSite => new Uri("http://www.andrewjamesbowen.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.andrewjamesbowen.com/rss/"); }
        }

        public string TwitterHandle => "Andrew_Beebs";
    }
}
