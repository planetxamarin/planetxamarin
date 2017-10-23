using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DamianMehers : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Damian";
        public string LastName => "Mehers";
        public string ShortBioOrTagLine => "Independent Xamarin Developer";
        public string StateOrRegion => "Geneva, Switzerland";
        public string EmailAddress => "damian@mehers.com";
        public string TwitterHandle => "DamianMehers";
        public string GravatarHash => "d77613f4e20bfcae401a6bf0018a83d1";
        public string GitHubHandle => "DamianMehers";
        public GeoPosition Position => new GeoPosition(46.3635288, 6.1860801);

        public Uri WebSite => new Uri("https://damian.fyi/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://damian.fyi/feed/"); }
        }

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}
