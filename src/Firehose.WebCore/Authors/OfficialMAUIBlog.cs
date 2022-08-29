using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class OfficialMAUIBlog : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "The .NET MAUI";
        public string LastName => "Blog";
        public string StateOrRegion => "Internet";
        public string EmailAddress => "hello@xamarin.com";
        public string ShortBioOrTagLine => "is your official source for .NET MAUI developer news.";
        public Uri WebSite => new Uri("https://blog.xamarin.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://devblogs.microsoft.com/dotnet/category/net-maui/feed/"); }
        }

        public string TwitterHandle => "dotnet";
        public string GravatarHash => "e7d599acf639d9d3883a0fd477b3ba42";
        public string GitHubHandle => "dotnet";
        public GeoPosition Position => new GeoPosition(37.7749300, -122.4194160);
        public bool Filter(SyndicationItem item) => true;
        public string FeedLanguageCode => "en";
    }
}