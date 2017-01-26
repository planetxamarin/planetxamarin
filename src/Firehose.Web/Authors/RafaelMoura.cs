using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class RafaelMoura : IAmAXamarinMVP
    {
        //DateTime IAmAXamarinMVP.FirstAwarded => new DateTime(2016, 2, 1);

        public string FirstName => "Rafael";
        public string LastName => "Moura";
        public string StateOrRegion => "Cuiabá, Brasil";
        public string TwitterHandle => "_rafa_moura_";
        public string GitHubHandle => "rafaelrmou";

        public string ShortBioOrTagLine
            => "C# mobile developer, community enthusiast, Xamarin MVP, author, blogger and Manager at Fidelity Mobile";

        public string EmailAddress => "contato@rm.eti.br";
        public string GravatarHash => "632e4b77c1b0460fa2ae7f78a85feab5";
        public GeoPosition Position => new GeoPosition(-15.6059914, -56.0926403);
        public Uri WebSite => new Uri("http://www.studyxnet.com.br");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.studyxnet.com.br/rss"); }
        }

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}