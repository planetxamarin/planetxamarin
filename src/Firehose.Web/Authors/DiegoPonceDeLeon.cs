using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DiegoPonceDeLeon : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Diego";
        public string LastName => "Ponce de León";
        public string StateOrRegion => "Alicante, Spain";
        public string EmailAddress => "malandro@gmail.com";
        public string ShortBioOrTagLine => "is a freelance software developer";
        public Uri WebSite => new Uri("http://xleon.net");
        public string TwitterHandle => "diegoxleon";
        public string GitHubHandle => "xleon";
        public string GravatarHash => "b9371d959d3460b285f7f5f679a45c73";
        public GeoPosition Position => new GeoPosition(38.8259465, 0.126317);

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://xleon.net/feed.xml"); }
        }

        public bool Filter(SyndicationItem item)
            => item.Links.Any(x => x.Uri.AbsoluteUri.ToLowerInvariant().Contains("xamarin"));
    }
}