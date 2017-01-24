using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class CanBilgin : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Can";
        public string LastName => "Bilgin";
        public string ShortBioOrTagLine => "Seasoned microsoft stack developer with passion for mobile development. Microsoft MVP for Windows Platform Development";
        public string StateOrRegion => "Sarajevo";
        public string EmailAddress => "can_bilgin@hotmail.com";
        public string TwitterHandle => "can_bilgin";
        public string GravatarHash => "3659d530c25e6188f7ef4c98ed100dc8";

        public Uri WebSite => new Uri("https://canbilgin.wordpress.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://canbilgin.wordpress.com/feed/"); }
        }

        public string GitHubHandle => "canbilgin";

        public bool Filter(SyndicationItem item)
        {
            return item.Title.Text.ToLowerInvariant().Contains("xamarin")
                   || item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }

        public GeoPosition Position => new GeoPosition(43.8938256, 18.3129519);
    }
}