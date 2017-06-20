using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MartijnVanDijk : IAmAMicrosoftMVP, IAmAXamarinMVP
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://medium.com/feed/@martijn00"); }
        }

        public string FirstName => "Martijn";
        public string LastName => "Van Dijk";
        public string StateOrRegion => "Amsterdam, Netherlands";
        public string EmailAddress => "mhvdijk@gmail.com";
        public string ShortBioOrTagLine => "is developing apps at Xablu, and working with MvvmCross";
        public Uri WebSite => new Uri("https://medium.com/@martijn00");
        public string TwitterHandle => "mhvdijk";
        public string GravatarHash => "22155f520ab611cf04f76762556ca3f5";
        public string GitHubHandle => "martijn00";
        public GeoPosition Position => new GeoPosition(52.3702160, 4.8951680);
    }
}
