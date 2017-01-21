using System;
using System.Linq;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DanielKrzyczkowski : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://mobileprogrammerblog.wordpress.com/feed/rss"); }
        }

        public string FirstName => "Daniel";
        public string LastName => "Krzyczkowski";
        public string StateOrRegion => "Warsaw, Poland";
        public string EmailAddress => "daniel.krzyczkowski@hotmail.com";
        public string ShortBioOrTagLine => "is passionate about Universal Windows Platform and Xamarin.";
        public Uri WebSite => new Uri("http://mobileprogrammer.pl");
        public string TwitterHandle => "DKrzyczkowski";
        public string GitHubHandle => "Daniel-Krzyczkowski";
        public string GravatarHash => "65e521a756dff3ac3c233e58afc9ee2b";
        public GeoPosition Position => new GeoPosition(52.230878, 21.010842);
        
          public bool Filter(SyndicationItem item)
          {
            return item.Title.Text.ToLowerInvariant().Contains("xamarin") && item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
          }
    }
}
