using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class WilliamRodriguez : IAmAMicrosoftMVP, IAmAXamarinMVP
    {
        public string FirstName => "William";
        public string LastName => "Rodriguez";
        public string StateOrRegion => "Curitiba, Brasil";
        public string TwitterHandle => "williamsrodz";
        public string GitHubHandle => "williamsrz";

        public string ShortBioOrTagLine
            => "C# mobile developer, community enthusiast, Microsoft & Xamarin MVP";

        public string EmailAddress => "ping@williamsrz.com.br";
        public string GravatarHash => "c8f3160f0a24c13821d14b8848d62cea";
        public GeoPosition Position => new GeoPosition(-25.4244290, -49.2653820);
        public Uri WebSite => new Uri("http://www.williamsrz.com.br");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.williamsrz.com.br/rss"); }
        }

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}