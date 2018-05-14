using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class EsmerlinMoya : IAmACommunityMember
    {
        public string FirstName => "Esmerlin";
        public string LastName => "Moya";
        public string ShortBioOrTagLine => "Web and Mobile Developer";
        public string StateOrRegion => "Dominican Republic";
        public string EmailAddress => "esmerlinmoya@gmail.com";
        public string TwitterHandle => "merlin1827";
        public string GitHubHandle => "esmerlinmoya";
        public string GravatarHash => "0f726e3531d5fdbb045dd788a24ec37d";
        public GeoPosition Position => new GeoPosition(18.503112, -69.889555);
        public Uri WebSite => new Uri("https://medium.com/@esmerlinmoya/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://medium.com/feed/@esmerlinmoya"); } }
        public string FeedLanguageCode => "en";
    }
}