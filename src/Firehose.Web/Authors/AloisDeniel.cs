using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AloisDeniel : IAmAMicrosoftMVP
    {
        public string FirstName => "Aloïs";

        public string LastName => "Deniel";

        public string StateOrRegion => "Rennes, France";

        public string EmailAddress => "alois.deniel@outlook.com";

        public string ShortBioOrTagLine => "is a french Microsoft MVP focused on mobile technologies.";

        public Uri WebSite => new Uri("http://aloisdeniel.github.io/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://aloisdeniel.github.io/feed"); }
        }

        public string TwitterHandle => "AloisDeniel";
        public string GravatarHash => "c0ee52c4665817f3957a0c5da646f53c";
        public string GitHubHandle => "aloisdeniel";

        public GeoPosition Position => new GeoPosition(48.1182843, -1.642746);
    }
}