using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ttirrell : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Trevor";
        public string LastName => "Tirrell";
        public string ShortBioOrTagLine => "is a Xamarin Certified Mobile Developer and Founder of ttirrell";
        public string StateOrRegion => "Greenville, SC";
        public string EmailAddress => "trevor@ttirrell.com";
        public string TwitterHandle => "TrevorTirrell";
        public string GravatarHash => "aa52960b7c71deb9ac4a18c62913842d";
        public string GitHubHandle => "ttirrell";
        public GeoPosition Position => new GeoPosition(34.86948, -82.404068);
        public Uri WebSite => new Uri("https://ttirrell.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://ttirrell.com/feed/"); } }
        public string FeedLanguageCode => "en";

        public bool Filter(SyndicationItem item)
            => item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("xamarin")) ?? false;
    }
}