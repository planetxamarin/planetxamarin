using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JohnWilson : IAmACommunityMember
    {
        public string FirstName => "John";
        public string LastName => "Wilson";
        public string StateOrRegion => "Brisbane, Australia";
        public string EmailAddress => "wislon@hotmail.com";
        public string ShortBioOrTagLine => "Head of Mobile, Tech Lead, Xamarin Specialist";
        public Uri WebSite => new Uri("https://blog.wislon.io/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.wislon.io/atom.xml"); }
        }

        public string TwitterHandle => "wislon";
        public string GravatarHash => "86c9d925c04b4c79c98bfc839d949e15";
        public string GitHubHandle => "wislon";
        public GeoPosition Position => new GeoPosition(-27.3812513,152.7130138);
        public string FeedLanguageCode => "en";
    }
}