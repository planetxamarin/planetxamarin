using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KerryLothrop : IAmAMicrosoftMVP, IAmAXamarinMVP
    {
        public string FirstName => "Kerry W.";
        public string LastName => "Lothrop";
        public string ShortBioOrTagLine => "Principal Consultant at Zühlke";
        public string StateOrRegion => "Frankfurt, Germany";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "kwlothrop";

        public Uri WebSite => new Uri("http://kerry.lothrop.de/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://kerry.lothrop.de/de/feed/"); }
        }

        public string GravatarHash => "250241b2800a1de895a75ce039bcfef4";
        public string GitHubHandle => string.Empty;
    }
}