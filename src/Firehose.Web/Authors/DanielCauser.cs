using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class DanielCauser : IAmACommunityMember
    {
        public string FirstName => "Daniel";
        public string LastName => "Causer";
        public string StateOrRegion => "Toronto, Canada";
        public string EmailAddress => "danielcauser@gmail.com";
        public string ShortBioOrTagLine => "is a Xamarin Certified Developer fan of Xamarin and Mobile Development.";
        public Uri WebSite => new Uri("https://causerexception.com/");
        public string TwitterHandle => "danielcauser";
        public string GitHubHandle => "danielcauser";
        public string GravatarHash => "2666956714a2c2d48c480a6bddac4071";
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://causerexception.com/feed"); } }
        public GeoPosition Position => new GeoPosition(43.653103, -79.383851);
        public string FeedLanguageCode => "en";
    }
}