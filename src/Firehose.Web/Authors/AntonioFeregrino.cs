using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AntonioFeregrino : IAmACommunityMember
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://thatcsharpguy.com/xamarin-feed.xml"); }
        }

        public string EmailAddress => "feregrino@thatcsharpguy.com";
        public string FirstName => "Antonio";
        public string LastName => "Feregrino";
        public string StateOrRegion => "Mexico City, Mexico";
        public string ShortBioOrTagLine => string.Empty;
        public string TwitterHandle => "io_exception";
        public Uri WebSite => new Uri("http://thatcsharpguy.com/tag/Xamarin/");
        public string GravatarHash => "";
        public string GitHubHandle => string.Empty;
        public GeoPosition Position => GeoPosition.Empty;
    }
}