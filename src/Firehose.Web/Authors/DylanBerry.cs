using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class DylanBerry : IAmACommunityMember
    {
        public string FirstName => "Dylan";
        public string LastName => "Berry";
        public string ShortBioOrTagLine => "Genetically Predisposed Programmer";
        public string StateOrRegion => "Toronto, Canada";
        public string EmailAddress => "dylanberry@gmail.com";
        public string TwitterHandle => "dylbot9000";
        public string GravatarHash => "8ef85938904ff43397d50caa9b0eebed";
        public string GitHubHandle => "dylanberry";
        public GeoPosition Position => new GeoPosition(43.653493, -79.384095);
        public Uri WebSite => new Uri("https://www.dylanberry.com/");
        public IEnumerable<Uri> FeedUris => new [] { new Uri("https://www.dylanberry.com/category/dotnet-maui/feed/"), new Uri("https://www.dylanberry.com/category/xamarin/feed/") };
        public string FeedLanguageCode => "en";
    }
}