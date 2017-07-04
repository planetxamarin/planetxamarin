using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class LoganEdge : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Logan";
        public string LastName => "Edge";
        public string StateOrRegion => "Tainan, Taiwan";
        public string EmailAddress => "finianex@gmail.com";
        public string ShortBioOrTagLine => "I'm not wolverine!";
        public Uri WebSite => new Uri("http://loganedge.tw");
        public string TwitterHandle => "";
        public string GitHubHandle => "";
        public string GravatarHash => "";
        public GeoPosition Position => new GeoPosition(23.1229948, 120.1062325);

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.loganedge.tw/feeds/posts/default"); }
        }

        public bool Filter(SyndicationItem item)
            => item.Links.Any(x => x.Uri.AbsoluteUri.ToLowerInvariant().Contains("xamarin"));
    }
}
