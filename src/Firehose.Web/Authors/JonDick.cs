using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JonDick : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Jon";
        public string LastName => "Dick";
        public string ShortBioOrTagLine => "";
        public string EmailAddress => "jondick@gmail.com";
        public string TwitterHandle => "redth";
        public string GravatarHash => "ad73e52d7e4d89e904e7c4cfd91fc2b9";
        public string StateOrRegion => "Ontario, Canada";
        public Uri WebSite => new Uri("https://redth.codes");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://redth.codes/feed/"); }
        }

        public string GitHubHandle => "redth";
        public GeoPosition Position => new GeoPosition(51.2537750, -85.3232140);
        public string FeedLanguageCode => "en";
    }
}