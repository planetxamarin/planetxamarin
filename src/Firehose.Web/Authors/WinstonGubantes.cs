using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class WinstonGubantes : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Winston";
        public string LastName => "Gubantes";
        public string ShortBioOrTagLine => "a Xamarin Developer at Gluon Consulting";
        public string StateOrRegion => "Davao City, Philippines";
        public string EmailAddress => "winston.gubantes@gmail.com";
        public string TwitterHandle => "tony_fear";
        public string GravatarHash => "9e1aea174237384361fc260b33559d05";
        public string GitHubHandle => "winstongubantes";
        public GeoPosition Position => new GeoPosition(7.1066271, 125.6294976);

        public Uri WebSite => new Uri("https://winstongubantes.blogspot.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://winstongubantes.blogspot.com/feeds/posts/default?alt=rss"); } }

        public bool Filter(SyndicationItem item)
        {
            // Of course you can make the checks as complicated as you want and combine some stuff
            return item.Title.Text.ToLowerInvariant().Contains("xamarin") && item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}