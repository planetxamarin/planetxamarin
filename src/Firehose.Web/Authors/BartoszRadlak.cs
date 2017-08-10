using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
    public class BartoszRadlak : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Bartosz";

        public string LastName => "Radlak";

        public string StateOrRegion => "Katowice, Poland";

        public string EmailAddress => "bartoszradlak@gmail.com";

        public string ShortBioOrTagLine => "is a C# developer and passionate about Microsoft technology stack, especially Xamarin.";

        public Uri WebSite => new Uri("http://radekkoduje.pl/");

        public string TwitterHandle => "RadlakBartosz";

        public string GitHubHandle => "bradlak";

        public string GravatarHash => "2b7cad778fa81c243c06c0ee0ad1f893";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://radekkoduje.pl/?cat=79&feed=rss2"); }
        }

        public GeoPosition Position => new GeoPosition(50.264891, 19.023781);

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}