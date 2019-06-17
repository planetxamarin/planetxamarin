using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class CarelLotz : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Carel";
        public string LastName => "Lotz";
        public string ShortBioOrTagLine => "is a Software Architect/Developer that loves to code";
        public string StateOrRegion => "Cape Town, South Africa";
        public string EmailAddress => "carel.lotz@gmail.com";
        public string TwitterHandle => "cjlotz";
        public string GitHubHandle => "cjlotz";
        public string GravatarHash => "0f692990601721c06f141f4fe860685e";
        public GeoPosition Position => new GeoPosition(-33.89635, 18.70199);
        
        public Uri WebSite => new Uri("https://cjlotz.github.io");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://cjlotz.github.io/feed.xml"); } }

        public bool Filter(SyndicationItem item) =>
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin")) &&
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("community"));

        public string FeedLanguageCode => "en";
    }
}