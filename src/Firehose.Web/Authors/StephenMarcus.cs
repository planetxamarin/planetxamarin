using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class StephenMarcus : IAmACommunityMember
   {
        public string FirstName => "Stephen";
        public string LastName => "Marcus";
        public string StateOrRegion => "Orange County, California";
        public string EmailAddress => "marcus@marcusts.com";
        public string ShortBioOrTagLine => "Certified Xamarin mobile app developer";
        public Uri WebSite => new Uri("https://www.marcusts.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.marcusts.com/category/Xamarin/feed/"); }
        }

        public string TwitterHandle => "";
        public string GravatarHash => "a64074b2ab0ac9b5a27379670b259d6d";
        public string GitHubHandle => "marcusts";
        public GeoPosition Position => new GeoPosition(33.64230, -117.69770);
        public string FeedLanguageCode => "en";

    }
}