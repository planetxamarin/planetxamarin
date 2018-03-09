using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DigitalCaesar : IAmACommunityMember
    {
        public string FirstName => "Digital";
        public string LastName => "Caesar";
        public string StateOrRegion => "Atlanta, GA";
        public string TwitterHandle => "Digital_Caesar";
        public string EmailAddress => "admin@digitalcaesar.com";
        public string ShortBioOrTagLine => "Bringing the digital world to life.";
        public string GravatarHash => "7c63b2b2254e3b0abf896577ab2746aa";
        public Uri WebSite => new Uri("https://digitalcaesar.com");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://digitalcaesar.com/rss/"); }
        }
        public string GitHubHandle => "digitalcaesar";
        public GeoPosition Position => new GeoPosition(33.30186, -84.5541);
        public string FeedLanguageCode => "en";
    }
}
