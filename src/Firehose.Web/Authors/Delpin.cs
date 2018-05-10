using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
    public class Delpin : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Delpin";

        public string LastName => "Susai Raj";

        public string ShortBioOrTagLine => "I'm a Xamarin Developer, C-Sharp Corner MVP";

        public string EmailAddress => "susairajs@outlook.com";

        public string TwitterHandle => "susairajs18";

        public string GravatarHash => "3408967b9598e7bb107baf15d5a15454";

        public string StateOrRegion => "Chennai,India";

        public Uri WebSite => new Uri("http://xamarinmonkeys.blogspot.in/");

        public GeoPosition Position => new GeoPosition(12.9199097,80.1688917);
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://xamarinmonkeys.blogspot.com/feeds/posts/default"); }
        }

        public string GitHubHandle => "susairajs";

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));

    }
}
