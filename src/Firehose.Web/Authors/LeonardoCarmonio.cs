using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class LeonardoCarmonio : IAmACommunityMember
    {
        public string FirstName => "Leonardo";
        public string LastName => "Carmonio";
        public string StateOrRegion => "Contagem, Brasil";
        public string TwitterHandle => "Leo_Carmonio";
        public string GitHubHandle => "leonardoCarmonio";
        public string ShortBioOrTagLine => "is a .NET Systems Analyst and Freelancer";
        public string EmailAddress => "leonardo.carmonio@gmail.com";
        public string GravatarHash => "98d7a761d855ffee9835a72a55448537";
        public GeoPosition Position => new GeoPosition(-19.9266861,-44.0984682);
        public Uri WebSite => new Uri("https://www.portalxamarin.com.br");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.portalxamarin.com.br/feed/"); }
        }

        public string FeedLanguageCode => "pt";
    }
} 