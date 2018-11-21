using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JulianoCustodio : IAmAMicrosoftMVP
    {
        public string FirstName => "Juliano";
        public string LastName => "Custóio";
        public string StateOrRegion => "Piracicaba, Brasil";
        public string TwitterHandle => "JuuCustodio";
        public string GitHubHandle => "JuuCustodio";
        public string ShortBioOrTagLine => "Microsoft MVP, Blogger and Speaker";
        public string EmailAddress => "juliano.custodio@hotmail.com.br";
        public string GravatarHash => "71de9936f2ffbc93e9918066479331f1";
        public GeoPosition Position => new GeoPosition(-22.7342864, -47.6480644);
        public Uri WebSite => new Uri("https://www.julianocustodio.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.julianocustodio.com/rss"); }
        }

        public string FeedLanguageCode => "pt";
    }
}