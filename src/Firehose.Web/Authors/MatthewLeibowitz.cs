using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
    public class MatthewLeibowitz : IWorkAtXamarinOrMicrosoft, IFilterMyBlogPosts
    {
        public string FirstName => "Matthew";
        public string LastName => "Leibowitz";
        public string ShortBioOrTagLine => "An all-round software guy. I live and breathe C# and .NET on any platform.";
        public string EmailAddress => "mattleibow@live.com";
        public string TwitterHandle => "mattleibow";
        public string GitHubHandle => "mattleibow";
        public string GravatarHash => "365da45bdc71334831f228aff805738f";
        public string StateOrRegion => "Cape Town, South Africa";
        public GeoPosition Position => new GeoPosition(-34.02231, 18.46716);
        
        public Uri WebSite => new Uri("https://dotnetdevaddict.co.za");
        
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://dotnetdevaddict.co.za/feed/"); }
        }
        
        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Contains("xamarin"));
        }
    }
}
