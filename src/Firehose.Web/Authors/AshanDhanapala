using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors {

    public class AshanDhanapala : IAmACommunityMember, IFilterMyBlogPosts{

        public string FirstName => "Ashan";
        public string LastName => "Dhanapala";
        public string ShortBioOrTagLine => "Senior Software Engineer, Mobile DevOps Practitioner, Xamarin Enthusiast and speaker at tech events";
        public string StateOrRegion => "Colombo, Sri Lanka;
        public string EmailAddress => "ashandhanapala@gmail.com";
        public string TwitterHandle => "ashanCodes";
        public string GravatarHash => "d58b6fd6c2d9f949345e8d14d203a4b2";

        public Uri WebSite => new Uri("https://ashancodes.wordpress.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://almirvuk.blogspot.ba/feeds/posts/default?alt=rss"); } }

        public string GitHubHandle => "ashanAtExilesoft";

        public GeoPosition Position => new GeoPosition(-25.2931, -49.2233);

        public bool Filter(SyndicationItem item) {
            return item.Title.Text.ToLowerInvariant().Contains("xamarin") && item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}
