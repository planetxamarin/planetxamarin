using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;
using System.ServiceModel.Syndication;
using System.Linq;

namespace Firehose.Web
{
    public class TomSoderling : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Tom";
        public string LastName => "Soderling";
        public string StateOrRegion => "Minneapolis, MN";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => "is a Sr. Mobile Developer, speaker, and open source contributor";
        public string TwitterHandle => "tomsoderling";
        public string GravatarHash => "dd103f377899fc63b0b88c5bb62b15bd";
        public GeoPosition Position => new GeoPosition(44.986656, -93.258133);

        public Uri WebSite => new Uri("https://tomsoderling.github.io");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://tomsoderling.github.io/feed.xml"); }
        }

        public string GitHubHandle => "TomSoderling";
        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}
