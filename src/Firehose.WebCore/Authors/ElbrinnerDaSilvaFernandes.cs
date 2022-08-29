using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class ElbrinnerDaSilvaFernandes : IAmACommunityMember
    {
        public string FirstName => "Elbrinner";
        public string LastName => "da Silva Fernandes";
        public string StateOrRegion => "Madrid , Spain";
        public string EmailAddress => "elbrinner@elbrinner.com";
        public string ShortBioOrTagLine => "is a Xamarin consultant in everis Spain and organizer of the meetup group Xamarin Madrid.";
        public Uri WebSite => new Uri("https://www.elbrinner.com/");
        public string TwitterHandle => "elbrinner";
        public string GitHubHandle => "elbrinner";
        public string GravatarHash => "15e64690c0e4d5b2c692e9fc7de5e768";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.elbrinner.com/rss"); }
        }

        public GeoPosition Position => new GeoPosition(40.4167750, -3.7037900);
        public string FeedLanguageCode => "es";
    }
} 