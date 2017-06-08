using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DawidSibinski : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Dawid";
        public string LastName => "Sibinski";
        public string ShortBioOrTagLine => ".NET Developer, Xamarin learner";
        public string StateOrRegion => "Wroclaw, Poland";
        public string EmailAddress => "dawid@dsibinski.pl";
        public string TwitterHandle => "DawidSibinski";
        public string GravatarHash => "426ee8727c91aac7c913dd69540a8910";
        public string GitHubHandle => "iks111";
        public GeoPosition Position => new GeoPosition(51.1078850, 17.0385380);

        public Uri WebSite => new Uri("http://www.dsibinski.pl");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://www.dsibinski.pl/category/xamarin/feed/"); } }

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}