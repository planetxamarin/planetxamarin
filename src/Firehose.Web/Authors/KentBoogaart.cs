using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KentBoogaart : IAmAMicrosoftMVP
    {
        public string FirstName => "Kent";
        public string LastName => "Boogaart";
        public string StateOrRegion => "Australia";
        public string EmailAddress => "kent.boogaart@gmail.com";
        public string ShortBioOrTagLine => "is a freelance software engineer working mainly in the mobile space";
        public Uri WebSite => new Uri("https://kent-boogaart.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://kent-boogaart.com/atom.xml"); }
        }

        public string TwitterHandle => "kent_boogaart";
        public string GravatarHash => "";
        public string GitHubHandle => string.Empty;
        public GeoPosition Position => new GeoPosition(-35.0004451, 138.3309978);
        public string FeedLanguageCode => "en";
    }
}