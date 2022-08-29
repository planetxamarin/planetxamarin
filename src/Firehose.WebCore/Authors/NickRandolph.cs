using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class NickRandolph : IAmAMicrosoftMVP
    {
        public string FirstName => "Nick";

        public string LastName => "Randolph";

        public string StateOrRegion => "Sydney, Australia";

        public string EmailAddress => "nick@builttoroam.com";

        public string ShortBioOrTagLine => "Microsoft MVP and maintainer of @MvvmCross. Co-founder, Tech Lead at Built to Roam (@btroam), special forces in cross platform app and cloud solutions.";

        public Uri WebSite => new Uri("https://builttoroam.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://nicksnettravels.builttoroam.com/syndication.axd"); }
        }

        public string TwitterHandle => "thenickrandolph";

        public string GravatarHash => "";

        public string GitHubHandle => "nickrandolph";

        public GeoPosition Position => new GeoPosition(-33.839559, 151.2112434);

        public string FeedLanguageCode => "en";
    }
}