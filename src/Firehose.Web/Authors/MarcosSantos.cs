using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarcosSantos : IAmACommunityMember
    {
        public string FirstName => "Marcos";
        public string LastName => "Barchiki dos Santos";
        public string ShortBioOrTagLine => string.Empty;
        public string StateOrRegion => "Colombo, Brasil";
        public string EmailAddress => "mhbsti@gmail.com";
        public string TwitterHandle => "mhbsantos";
        public string GitHubHandle => "mhbsti";
        public string GravatarHash => "ec11acf314f3c83e09f790891d411162";
        public GeoPosition Position => new GeoPosition(-25.292939, -49.226630);
        public Uri WebSite => new Uri("https://www.mhbs.com.br");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.mhbs.com.br/rss"); } }
        public string FeedLanguageCode => "pt";
    }
}