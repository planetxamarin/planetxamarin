using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class WinstonGubantes : IAmACommunityMember
    {
        public string FirstName => "Winston";
        public string LastName => "Gubantes";
        public string ShortBioOrTagLine => "a Xamarin Developer at Gluon Consulting";
        public string StateOrRegion => "Davao City, Philippines";
        public string EmailAddress => "winston.gubantes@gmail.com";
        public string TwitterHandle => "tony_fear";
        public string GravatarHash => "9e1aea174237384361fc260b33559d05";
        public string GitHubHandle => "winstongubantes";
        public GeoPosition Position => new GeoPosition(7.1066271, 125.6294976);
        public Uri WebSite => new Uri("https://winstongubantes.blogspot.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://winstongubantes.blogspot.com/feeds/posts/default?alt=rss"); } }
        public string FeedLanguageCode => "es";
    }
}