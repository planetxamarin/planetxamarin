using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class KymPhillpotts : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Kym";
        public string LastName => "Phillpotts";
        public string ShortBioOrTagLine => "is one of the Xamarin University instructors";
        public string StateOrRegion => "Melbourne, Australia";
        public string EmailAddress => "kphillpotts@gmail.com";
        public string TwitterHandle => "kphillpotts";
        public string GravatarHash => "3218e66502c6f0836dfd0f02f210ba0b";
        public Uri WebSite => new Uri("https://kymphillpotts.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://kymphillpotts.com/feed"); }
        }

        public string GitHubHandle => "kphillpotts";
        public GeoPosition Position => new GeoPosition(-37.8136280, 144.9630580);
        public string FeedLanguageCode => "en";
    }
}
