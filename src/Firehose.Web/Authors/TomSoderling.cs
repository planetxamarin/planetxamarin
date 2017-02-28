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
        public string StateOrRegion => "MPLS";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => string.Empty;
        public string TwitterHandle => "tomsoderlng";
        public string GravatarHash => "dd103f377899fc63b0b88c5bb62b15bd";
        public GeoPosition Position => GeoPosition.Empty;

        public Uri WebSite => new Uri("https://mobilecomposer.github.io");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://mobilecomposer.github.io/feed.xml"); }
        }

        public string GitHubHandle => string.Empty;

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}