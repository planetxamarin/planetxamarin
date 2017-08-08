using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class VulcanLee : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Vulcan";
        public string LastName => "Lee";
        public string StateOrRegion => "Taipei, Taiwan";
        public string TwitterHandle => "vulcanlee";
        public string EmailAddress => "vulcan.lee@gmail.com";
        public string ShortBioOrTagLine => "Vulcan Lee is a Microsoft MVP who develops Xamarin at Doggy Ltd";
        public string GravatarHash => "f5de84ba365a15a05748624c07e70075";
        public Uri WebSite => new Uri("https://mylabtw.blogspot.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://mylabtw.blogspot.com/feeds/posts/default?alt=rss"); }
        }

        public string GitHubHandle => "vulcanlee";

        public bool Filter(SyndicationItem item)
        {
            // if my blog has keyword, disableplanetxamarin, Prohibit publishing to on planetxamarin
            if (item.Title.Text.ToLowerInvariant().Contains("disableplanetxamarin") || 
                item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("disableplanetxamarin")))
                return false;

            return item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
                item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
        }
        
        public GeoPosition Position => new GeoPosition(25.043847, 121.525645);
    }
}
