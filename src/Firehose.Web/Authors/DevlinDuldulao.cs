using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DevlinDuldulao : IFilterMyBlogPosts, IAmACommunityMember
    {
        public string FirstName => "Devlin";
        public string ShortBioOrTagLine => "is a Xamarin developer, a trainer, and a speaker";
        public string StateOrRegion => "Philippines";
        public string LastName => "Duldulao";
        public string EmailAddress => "webmasterdevlin@gmail.com";
        public string TwitterHandle => "DevlinDuldulao";
        public string GitHubHandle => "webmasterdevlin";
        public string GravatarHash => "7dc408ee2ccfa6fb9eac30cdf08926bf";

        public GeoPosition Position => new GeoPosition(10.3787569, 123.7762541);

        public Uri WebSite => new Uri("https://devlinduldulao.pro/");

        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://devlinduldulao.pro/feed/"); } }

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}