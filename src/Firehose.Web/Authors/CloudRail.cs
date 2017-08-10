using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class CloudRail : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "CloudRail";
        public string LastName => "";
        public string StateOrRegion => "Germany";
        public string TwitterHandle => "cloudrail";
        public string EmailAddress => "carsten.jacobsen@cloudrail.com";
        public string ShortBioOrTagLine => "CloudRail API Integration Solution make it easy to integrate social, storage, messaging, location and payment APIs in your app.";
        public string GravatarHash => "e4359f28348600ffffa597226738cb95";
        public Uri WebSite => new Uri("https://cloudrail.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.cloudrail.com/feed/"); }
        }

        public string GitHubHandle => "CloudRail";

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
        public GeoPosition Position => new GeoPosition(49.4736807, 8.474981699999944);
    }
}
