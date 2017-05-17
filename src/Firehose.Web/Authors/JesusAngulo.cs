using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
    public class JesusAngulo : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Jesús";

        public string LastName => "Angulo";

        public string StateOrRegion => "Lima";

        public string EmailAddress => "jesus.angulo@outlook.com";

        public string ShortBioOrTagLine => "Certified Xamarin Mobile Developer";

        public Uri WebSite => new Uri("https://somostechies.com");

        public string TwitterHandle => "jesulink2514";

        public string GitHubHandle => "jesulink2514";

        public string GravatarHash => "63359672e0ecb75e7ed261a358bf0478";

        public IEnumerable<Uri> FeedUris
        {
            get
            {
                yield return new Uri("https://somostechies.com/rss/");
            }
        }

        public GeoPosition Position => new GeoPosition(-12.0896427,-77.0060778);

        public bool Filter(SyndicationItem item)
        {
            return item.Title.Text.ToLowerInvariant().Contains("xamarin") || item.Categories.Any(x=> x.Name.ToLowerInvariant() == "xamarin");
        }
    }
}