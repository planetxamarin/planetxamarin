using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
    public class GeertVanDerCruijsen : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Geert";
        public string LastName => "van der Cruijsen";
        public string ShortBioOrTagLine => string.Empty;
        public string EmailAddress => "";
        public string TwitterHandle => "geertvdc";
        public string GravatarHash => "ec02820495ff6d50e58dd027aa2b0ae3";

        public string StateOrRegion => "Uden, Netherlands";
        public Uri WebSite => new Uri("https://mobilefirstcloudfirst.net");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://mobilefirstcloudfirst.net/feed"); }
        }

        public string GitHubHandle => string.Empty;
        public GeoPosition Position => new GeoPosition(51.6631070, 5.6239230);

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}