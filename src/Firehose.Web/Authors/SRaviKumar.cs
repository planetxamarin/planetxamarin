using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SRaviKumar : IAmACommunityMember
    {
        public string FirstName => "S Ravi";
        public string LastName => "Kumar";
        public string ShortBioOrTagLine => string.Empty;
        public string StateOrRegion => "Greater Noida, India";
        public string EmailAddress => "techierathore@gmail.com";
        public string TwitterHandle => "techierathore";
        public string GravatarHash => "b850b7ab6cd9cdb2d5edc6739b624fdf";
        public GeoPosition Position => new GeoPosition(28.4743880, 77.5039900);
        public Uri WebSite => new Uri("https://techierathore.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://techierathore.com/feed/"); }
        }

        public string GitHubHandle => string.Empty;
        public string FeedLanguageCode => "en";
    }
}