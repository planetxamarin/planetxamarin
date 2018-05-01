using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class WilliamBarbosa : IAmAMicrosoftMVP
    {
        public string FirstName => "William";
        public string LastName => "Barbosa";
        public string StateOrRegion => "Santos, Brasil";
        public string TwitterHandle => "willdotnet";
        public string GitHubHandle => "willsb";
        public string ShortBioOrTagLine => "Microsoft MVP, Blogger, Speaker, Monkey Nights Co-founder/Host and MvvmCross contributor";
        public string EmailAddress => "heytherewill@gmail.com";
        public string GravatarHash => "e47d219e8ee5d6dd5a44940dc26585c4";
        public GeoPosition Position => new GeoPosition(-23.954821, -46.3247136);
        public Uri WebSite => new Uri("https://willsb.github.io");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://medium.com/feed/@heytherewill"); }
        }

        public string FeedLanguageCode => "en";
    }
}