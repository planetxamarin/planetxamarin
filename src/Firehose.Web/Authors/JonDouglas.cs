using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JonDouglas : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Jon";
        public string LastName => "Douglas";
        public string ShortBioOrTagLine => string.Empty;
        public string StateOrRegion => "Utah";
        public string EmailAddress => "";
        public string TwitterHandle => "_jondouglas";
        public Uri WebSite => new Uri("https://www.jon-douglas.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.jon-douglas.com/atom.xml"); }
        }

        public string GravatarHash => "83d67df0b9e002d1c55a2786aeeb0c1b";
        public string GitHubHandle => "JonDouglas";
        public GeoPosition Position => new GeoPosition(39.3209800, -111.0937310);
        public string FeedLanguageCode => "en";
    }
}