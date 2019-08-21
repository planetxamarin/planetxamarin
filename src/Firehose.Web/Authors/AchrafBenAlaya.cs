using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AchrafBenAlaya : IAmACommunityMember , IFilterMyBlogPosts
    {
        public string FirstName => "Achraf";
        public string LastName => "Ben Alaya";
        public string StateOrRegion => "SFAX, Tunisia";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => "Helping enthusiasts developers to learn Xamarin.Forms,ASP.NET,azure";
        public Uri WebSite => new Uri("https://achrafbenalayablog.azurewebsites.net");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://achrafbenalayablog.azurewebsites.net/index.php/category/xamarin/"); }
        }

        public string TwitterHandle => "AchrafBenAlaya";
        public string GravatarHash => "a1ff79feef7008f3e385b9940d4fb2b5";
        public string GitHubHandle => "achrafbenalaya";
        public GeoPosition Position => new GeoPosition(34.74056, 10.76028);
        public string FeedLanguageCode => "en";
    }
}
