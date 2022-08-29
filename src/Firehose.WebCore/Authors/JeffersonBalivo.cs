using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class JeffersonBalivo : IAmACommunityMember
    {
        public string FirstName => "Jefferson";
        public string LastName => "Balivo";
        public string StateOrRegion => "Jaú, São Paulo, Brazil";
        public string EmailAddress => "jefferson@balivo.com.br";
        public string ShortBioOrTagLine => "Xamarin Enthusiast, Technical Lead and Cross Platform Architect, Multi-Plataform Technical Audience Contributor (MTAC), Technical Writer and Speaker";
        public Uri WebSite => new Uri("https://balivo.com.br/");
        public string TwitterHandle => "jbalivo";
        public string GitHubHandle => "balivo";
        public string GravatarHash => "e5a95c365e8f06786d6439474bc733df";
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://balivo.com.br/rss"); } }
        public GeoPosition Position => new GeoPosition(-22.2997067, -48.5931324);
        public string FeedLanguageCode => "pt";
    }
}