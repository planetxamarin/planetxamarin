using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarcoKuiper : IAmACommunityMember
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://feeds2.feedburner.com/marcofolio"); }
        }

        public string EmailAddress => "marco@marcofolio.net";
        public string FirstName => "Marco";
        public string LastName => "Kuiper";
        public string StateOrRegion => "The Netherlands";
        public string ShortBioOrTagLine => "Code monkey";
        public string TwitterHandle => "marcofolio";
        public Uri WebSite => new Uri("http://www.marcofolio.net/");
        public string GravatarHash => "";
    }
}