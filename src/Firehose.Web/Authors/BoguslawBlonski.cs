using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{

    public class BoguslawBlonski : IAmACommunityMember
    {

        public string FirstName => "Boguslaw";
        public string LastName => "Blonski";
        public string ShortBioOrTagLine => "Generalist who is pragmatic and has delivered real code to real users in a variety of shapes.";
        public string StateOrRegion => "Lezajsk, Poland";
        public string EmailAddress => "boguslawblonski@gmail.com";
        public string TwitterHandle => "filipoff";
        public string GravatarHash => "d48c54ac95492ddadfc221b646d4c612";

        public Uri WebSite => new Uri("https://medium.com/@boguslawblonski");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://medium.com/feed/@boguslawblonski/"); } }

        public string GitHubHandle => "filipoff2";

        public GeoPosition Position => new GeoPosition(50.2684647, 22.3819053);
        public string FeedLanguageCode => "en";
    }
}