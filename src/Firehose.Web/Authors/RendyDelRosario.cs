using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RendyDelRosario : IAmACommunityMember
    {
        public string FirstName => "Rendy";
        public string LastName => "Del Rosario";
        public string ShortBioOrTagLine => "is a senior software developer with a passion for mobile development using Xamarin platform";
        public string StateOrRegion => "Dominican Republic";
        public string EmailAddress => "rendy@crossgeeks.com";
        public string TwitterHandle => "rdelrosario";
        public string GravatarHash => "4bece0ce1c33e65177110bcb95688c68";
        public string GitHubHandle => "rdelrosario";
        public GeoPosition Position => new GeoPosition(18.486058,-69.931212);
        public Uri WebSite => new Uri("https://xamboy.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://xamboy.com/rss"); } }
        public string FeedLanguageCode => "en";
    }
}