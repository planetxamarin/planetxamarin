using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JulianoCustodio : IAmACommunityMember
    {
        public string FirstName => "Juliano";
        public string LastName => "Custódio";
        public string StateOrRegion => "Sorocaba, Brasil";
        public string TwitterHandle => "JuuCustodio";
        public string GitHubHandle => "JuuCustodio";
        public string ShortBioOrTagLine => "Mobile developer";
        public string EmailAddress => "juliano.custodio@hotmail.com.br";
        public string GravatarHash => "71de9936f2ffbc93e9918066479331f1";
        public GeoPosition Position => new GeoPosition(-23.52425, -47.46501);
        public Uri WebSite => new Uri("https://www.julianocustodio.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.julianocustodio.com/rss"); }
        }

        public string FeedLanguageCode => "pt";
    }
}