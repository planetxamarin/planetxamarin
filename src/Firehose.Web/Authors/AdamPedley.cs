using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AdamPedley : IAmAMicrosoftMVP
    {
        public string FirstName => "Adam";

        public string LastName => "Pedley";

        public string StateOrRegion => "Melbourne, Australia";

        public string EmailAddress => "adam.pedley@gmail.com";

        public string ShortBioOrTagLine => string.Empty;

        public Uri WebSite => new Uri("https://xamarinhelp.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://xamarinhelp.com/feed/"); }
        }

        public string TwitterHandle => "adpedley";

        public string GravatarHash => "";
        public string GitHubHandle { get; }
        public GeoPosition Position => new GeoPosition(-37.8136280, 144.9630580);

        public string FeedLanguageCode => "en";
    }
}