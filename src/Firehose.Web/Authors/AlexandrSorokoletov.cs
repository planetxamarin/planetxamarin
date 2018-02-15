using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AlexandrSorokoletov : IAmAMicrosoftMVP
    {
        public string FirstName => "Alexandr";
        public string LastName => "Sorokoletov";
        public string ShortBioOrTagLine => "when he's not developing mobile applications enjoys snowboarding, kitesurfing and travel";
        public string StateOrRegion => "Washington, D.C.";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "AlexSorokoletov";
        public string GitHubHandle => "alexsorokoletov";
        public GeoPosition Position => new GeoPosition(38.905147, -77.065189);
        public Uri WebSite => new Uri("https://sorokoletov.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://sorokoletov.com/atom.xml"); } }
        public string GravatarHash => "b07fef8827dd03655303751e2fd5ca95";
        public string FeedLanguageCode => "en";
    }
}