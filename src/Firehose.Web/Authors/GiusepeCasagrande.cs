using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GiusepeCasagrande : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Giusepe";
        public string LastName => "Casagrande";
        public string ShortBioOrTagLine => string.Empty;
        public string StateOrRegion => "Rs, Brazil";
        public string EmailAddress => "giusepe@gmail.com";
        public string TwitterHandle => "giusepe";
        public string GravatarHash => "";

        public Uri WebSite => new Uri("http://giusepe.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://giusepe.com/rss"); }
        }

        public string GitHubHandle => string.Empty;

        public bool Filter(SyndicationItem item)
        {
            return item.Title.Text.ToLowerInvariant().Contains("xamarin")
                   || item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
        public GeoPosition Position => new GeoPosition(-30.0346320, -51.2176990);
    }
}