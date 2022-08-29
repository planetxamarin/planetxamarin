/*using Firehose.Web.Infrastructure;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Extensions;

namespace Firehose.Web.Authors
{
    public class MalcolmJack : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string EmailAddress => "inquisitorjax@gmail.com";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://inquisitorjax.blogspot.co.za/feeds/posts/default?alt=rss"); }
        }

        public string FirstName => "Malcolm";
        public string GitHubHandle => "inquisitorjax";
        public string GravatarHash => "9bcc032686b05244e77871d066f22aa6";
        public string LastName => "Jack";
        public GeoPosition Position => new GeoPosition(-33.853761, 18.658634);
        public string ShortBioOrTagLine => "Superhero in-training building a side-project into a startup using Xamarin and Azure";
        public string StateOrRegion => "Cape Town, South Africa";
        public string TwitterHandle => "inquisitorjax";
        public Uri WebSite => new Uri("https://inquisitorjax.blogspot.com/");

        public string FeedLanguageCode => "en";

        public bool Filter(SyndicationItem item)
        {
            if (item.Title.Text.StartsWith("daily links", StringComparison.InvariantCultureIgnoreCase))
                return false;

            if (item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("dailylinks")) ?? false)
                return false;

            return item.ApplyDefaultFilter();
        }
    }
}*/
