using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JamesTsai : IAmAMicrosoftMVP
    {
        public string FirstName => "James";
        public string LastName => "Tsai";
        public string StateOrRegion => "Taipei, Taiwan";
        public string TwitterHandle => "";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => "James Tsai is a Microsoft MVP who develops Xamarin at ThinkPower Ltd";
        public string GravatarHash => "";
        public Uri WebSite => new Uri("http://xamarintech.blogspot.tw/");
        public GeoPosition Position => new GeoPosition(25.078713, 121.570265);

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://xamarintech.blogspot.tw/feeds/posts/default?alt=rss"); }
        }

        public string GitHubHandle => "Jatsai";
        
        public bool Filter(SyndicationItem item)
        {
            return item.Title.Text.ToLowerInvariant().Contains("xamarin") || item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
         
        }

  
    }
}
