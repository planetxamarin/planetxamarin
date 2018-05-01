using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JesusAngulo : IAmAMicrosoftMVP
    {
        public string FirstName => "Jesús";
        public string LastName => "Angulo";
        public string StateOrRegion => "Lima";
        public string EmailAddress => "jesus.angulo@outlook.com";
        public string ShortBioOrTagLine => "Microsoft MVP | Certified Xamarin Mobile Developer";
        public Uri WebSite => new Uri("https://somostechies.com");
        public string TwitterHandle => "jesulink2514";
        public string GitHubHandle => "jesulink2514";
        public string GravatarHash => "63359672e0ecb75e7ed261a358bf0478";

        public IEnumerable<Uri> FeedUris
        {
            get
            {
                yield return new Uri("https://somostechies.com/rss/");
            }
        }

        public GeoPosition Position => new GeoPosition(-12.0896427,-77.0060778);
        public string FeedLanguageCode => "en";
    }
}