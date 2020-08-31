using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DanielMonetelli : IAmACommunityMember, IAmAYoutuber
    {
        public string FirstName => "Daniel Angel";
        public string LastName => "Monettelli L.";
        public string ShortBioOrTagLine => "is a Software Engineer, Videoblogger, Xamarin Mobile Developer & UI/UX Architect.";
        public string StateOrRegion => "Arequipa, Perú";
        public string EmailAddress => "danielmonetelli@hotmail.com";
        public Uri WebSite => new Uri("https://danielmonettelli.github.io");

        public IEnumerable<Uri> FeedUris
        {
            get
            {
                return new Uri[]
                {
                    new Uri("https://danielmonettelli.github.io/feed.xml"),
                    new Uri("https://www.youtube.com/feeds/videos.xml?channel_id=UCTAlbAORoFvAHj7jA4DLSFQ")
                };
            }
        }

        public string TwitterHandle => "DanielMonetelli";
        public string GravatarHash => "4b3d0e60019ad8fe1e4d7cd5c8850efb";
        public string GitHubHandle => "danielmonettelli";
        public GeoPosition Position => new GeoPosition(-16.4042643, -71.5486383);
        public string FeedLanguageCode => "en";
    }
}
