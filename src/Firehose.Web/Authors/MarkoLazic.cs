using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarkoLazic : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Marko";
        public string LastName => "Lazic";
        public string ShortBioOrTagLine => "Software engineer, tech enthusiast, passionate traveler";
        public string StateOrRegion => "Serbia";
        public string EmailAddress => "marko.lazic88@gmail.com";
        public string TwitterHandle => "markolazic88";
        public string GravatarHash => "5645586a7d29654e9b296b1409107014";

        public Uri WebSite => new Uri("http://markolazic.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://markolazic.com/feed/"); }
        }

        public string GitHubHandle => "markolazic88";

        public bool Filter(SyndicationItem item)
        {
            return item.Title.Text.ToLowerInvariant().Contains("xamarin")
                   || item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }

        public GeoPosition Position => new GeoPosition(44.7866, 20.4489);
    }
}
