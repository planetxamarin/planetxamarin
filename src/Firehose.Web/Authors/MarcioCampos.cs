using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarcioCampos : IAmACommunityMember
    {
        public string FirstName => "Márcio";
        public string LastName => "Campos";
        public string StateOrRegion => "Contagem, Brasil";
        public string TwitterHandle => "marciovcs";
        public string GitHubHandle => "marciovcs";
        public string ShortBioOrTagLine => "Systems analyst";
        public string EmailAddress => "marcio.campos@outlook.com";
        public string GravatarHash => "f383026969bde3fee0d3a37fec6cb097";
        public GeoPosition Position => new GeoPosition(-19.9386, -44.0529);
        public Uri WebSite => new Uri("https://www.portalxamarin.com.br");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.portalxamarin.com.br/feed/"); }
        }

        public string FeedLanguageCode => "pt";
    }
}