using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JasonDeBoever : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Jason";
        public string LastName => "DeBoever";
        public string StateOrRegion => "Ann Arbor, MI";
        public string TwitterHandle => "jdeboever";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => "Xamarin University Instructor";
        public string GravatarHash => "f4b74e01a10615612371789e9bce74dd";
        public Uri WebSite => new Uri("https://thisoldbrain.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://thisoldbrain.com/rss/"); }
        }

        public string GitHubHandle => "jasallen";

        public GeoPosition Position => new GeoPosition(42.2733786, -83.7727088);

        public string FeedLanguageCode => "en";
    }
}
