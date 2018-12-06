using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JimBennett : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Jim";
        public string LastName => "Bennett";
        public string ShortBioOrTagLine => "is the author of Xamarin in Action and a all-round nice guy";
        public string StateOrRegion => "Auckland, New Zealand";
        public string EmailAddress => "jim@jimbobbennett.io";
        public string TwitterHandle => "jimbobbennett";
        public Uri WebSite => new Uri("https://jimbobbennett.io/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.jimbobbennett.io/rss"); }
        }

        public string GravatarHash => "";
        public string GitHubHandle => string.Empty;
        public GeoPosition Position => new GeoPosition(-36.8484600, 174.7633320);
        public string FeedLanguageCode => "en";
    }
}