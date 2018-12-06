using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

public class AnbuMani : IAmACommunityMember
    {
        public string FirstName => "Anbu";
        public string LastName => "Mani";
        public string ShortBioOrTagLine => "I'm Always love with Working in Community";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "anbu_mani27";
        public string GravatarHash => "f97650474e4aa5b9609a28dcfdb052d4";
        public string StateOrRegion => "Chennai, India";
        public Uri WebSite => new Uri("https://www.xmonkeys360.com/");
        public GeoPosition Position => new GeoPosition(13.029217,80.2082503);

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://xmonkeys360.com/feed/"); }
        }

        public string GitHubHandle => "AnbuMani27";
        public string FeedLanguageCode => "en";
}
