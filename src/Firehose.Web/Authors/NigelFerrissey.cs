using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class NigelFerrissey : IAmACommunityMember
    {
        public string FirstName => "Nigel";
        public string LastName => "Ferrissey";
        public string ShortBioOrTagLine => "Mobile and front-end developer, Xamarin specialist";
        public string EmailAddress => "n_ferrissey@hotmail.com";
        public string TwitterHandle => "nferrissey";
        public string GravatarHash => "106ec2de3e2ea4e88e9fc431974f5d53";
        public string StateOrRegion => "Brisbane, Australia";
        public Uri WebSite => new Uri("https://xamarininsider.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://xamarininsider.com/rss/"); }
        }

        public string GitHubHandle => "nigelferrissey";
        public GeoPosition Position => new GeoPosition(-27.469657, 153.025241);
        public string FeedLanguageCode => "en";
    }
}