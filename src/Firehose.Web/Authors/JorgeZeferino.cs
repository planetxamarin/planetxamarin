using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JorgeZeferino : IAmACommunityMember, IFilterMyBlogPosts
    {
        private const string Xamarin = "xamarin";

        public string FirstName => "Jorge";
        public string LastName => "Zeferino";
        public string ShortBioOrTagLine => string.Empty;
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "jzeferin0";
        public string GitHubHandle => "jzeferino";
        public string GravatarHash => "93a97639407250975f8f7c72fe6d5620";
        public string StateOrRegion => "Portugal";
        public GeoPosition Position => new GeoPosition(38.753778, -9.092031);
        public Uri WebSite => new Uri("https://jzeferino.wordpress.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://jzeferino.wordpress.com/feed/"); }
        }

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains(Xamarin) ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains(Xamarin));
    }
}
