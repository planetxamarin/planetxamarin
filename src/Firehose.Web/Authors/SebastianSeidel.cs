using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SebastianSeidel : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Sebastian";
        public string LastName => "Seidel";
        public string ShortBioOrTagLine => "is using Xamarin since he got his first smartphone.";
        public string StateOrRegion => "Bad Oeynhausen, Germany";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "cayas_software";
        public Uri WebSite => new Uri("https://blog.cayas.de/");
        public string GravatarHash => "67dd9a9a01f36e0eca4f41b6464fdbe7";
        public string GitHubHandle => string.Empty;
        public GeoPosition Position => new GeoPosition(52.212539, 8.812332);

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.cayas.de/feed/rss"); }
        }

        public bool Filter(SyndicationItem item)
        {
            var allowedCategories = new[] { "xamarin", "android", "ios" };

            var hasAllowedCategory = item.Categories?.Any(category =>
                allowedCategories.Contains(category.Name.ToLowerInvariant())) ?? false;

            var title = item.Title.Text.ToLowerInvariant();

            return title.Contains("xamarin") || hasAllowedCategory;
        }

        public string FeedLanguageCode => "en";
    }
}