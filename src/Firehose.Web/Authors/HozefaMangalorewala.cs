using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class HozefaMangalorewala : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Hozefa";
        public string LastName => "Mangalorewala";
        public string StateOrRegion => "Riyadh, KSA";
        public string EmailAddress => "hozefam@gmail.com";
        public string ShortBioOrTagLine => "Xamarin Enthusiast";
        public Uri WebSite => new Uri("http://www.hozefam.com");
        public string TwitterHandle => "hozefam";
        public string GitHubHandle => "hozefam";
        public string GravatarHash => "922f695b27d1116afa09c3cad0bee594";
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://hozefam.com/rss"); } }
        public GeoPosition Position => new GeoPosition(24.6755991, 46.7388250);

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
            
        }
    }
}