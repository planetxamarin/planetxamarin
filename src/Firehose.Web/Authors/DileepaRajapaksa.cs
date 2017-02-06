using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
    public class DileepaRajapaksa : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Dileepa";
        
        public string LastName => "Rajapaksa";
        
        public string ShortBioOrTagLine => "The Passionate Xam Dev Techie";
        
        public string EmailAddress => string.Empty;
        
        public string TwitterHandle => "dsrajapaksa";
        
        public string GravatarHash => "4e90024f47f7dc06e993eaa4d33c86ac";
        
        public string StateOrRegion => "Colombo,Sri Lanka";
        
        public Uri WebSite => new Uri("http://blog.dileepatech.net/");
      

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://blog.dileepatech.net/feed/"); }
        }

        public string GitHubHandle => "dsrajapaksa";

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
        public GeoPosition Position => new GeoPosition(6.9270790, 79.8612430);
    }
}
