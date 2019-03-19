using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;


namespace Firehose.Web.Authors
{
    public class AllanRitchie : IAmAXamarinMVP, IAmAMicrosoftMVP
    {
        public string FirstName => "Allan";

        public string LastName => "Ritchie";

        public string StateOrRegion => "Toronto, Canada";

        public string EmailAddress => "allan.ritchie@gmail.com";

        public string ShortBioOrTagLine => "";

        public Uri WebSite => new Uri("https://allancritchie.net");

        public string TwitterHandle => "allanritchie911";

        public string GitHubHandle => "aritchie";

        public string GravatarHash => "5f22bd04ca38ed4d0a5225d0825e0726";

        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://allancritchie.net/xamarin.rss"); } }

        public GeoPosition Position => new GeoPosition(43.6425701,-79.3892455);

        public string FeedLanguageCode => "en";
    }
}