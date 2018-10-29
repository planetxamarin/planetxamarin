using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

public class Delpin : IAmACommunityMember
    {
        public string FirstName => "Delpin";
        public string LastName => "Susai Raj";
        public string ShortBioOrTagLine => "I'm Always love with Working in Community";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "susairajs18";
        public string GravatarHash => "3408967b9598e7bb107baf15d5a15454";
        public string StateOrRegion => "Chennai, India";
        public Uri WebSite => new Uri("https://xamarinmonkeys.blogspot.com/");
        public GeoPosition Position => new GeoPosition(12.9199515,80.1688917);

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://xamarinmonkeys.blogspot.com/feeds/posts/default"); }
        }

        public string GitHubHandle => "susairajs";
        public string FeedLanguageCode => "en";
}
