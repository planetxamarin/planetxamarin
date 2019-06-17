using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class OfficialXamarinBlog : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "The Xamarin";
        public string LastName => "Blog";
        public string StateOrRegion => "Internet";
        public string EmailAddress => "hello@xamarin.com";
        public string ShortBioOrTagLine => "is your official source for Xamarin developer news.";
        public Uri WebSite => new Uri("https://blog.xamarin.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://devblogs.microsoft.com/xamarin/feed/"); }
        }

        public string TwitterHandle => "xamarinhq";
        public string GravatarHash => "70148d964bb389d42547834e1062c886";
        public string GitHubHandle => "xamarin";
        public GeoPosition Position => new GeoPosition(37.7749300, -122.4194160);
        public bool Filter(SyndicationItem item) => true;
        public string FeedLanguageCode => "en";
    }
}