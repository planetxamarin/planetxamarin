using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Firehose.Web.Infrastructure;
using System.ServiceModel.Syndication;
using Firehose.Web.Extensions;

namespace Firehose.Web.Authors
{
    public class GiampaoloTucci : IAmACommunityMember
    {
        public Uri WebSite => new Uri("https://www.informaticapressapochista.com/it");
        public string FirstName => "Giampaolo";
        public string LastName => "Tucci";
        public string StateOrRegion => "Italia";
        public string EmailAddress => "g.tucci@informaticapressapochista.com";
        public string ShortBioOrTagLine => "L'IT come non l'avete mai letta";
        public string GravatarHash => "a8846caf48c8ccc9850ff201c1e2ad1d";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.informaticapressapochista.com/it/?format=feed&type=rss"); }
        }

        public string TwitterHandle => "GiampaoloTUCCI";
        public string GitHubHandle => "gptucci";
        public GeoPosition Position => new GeoPosition(44.40138, 8.93419);
        public string FeedLanguageCode => "it";
    }
}
