using Firehose.Web.Infrastructure;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
    public class WilliamRodriguez : IAmAMicrosoftMVP, IAmAXamarinMVP
    {
        public string FirstName => "William";
        public string LastName => "Rodriguez";
        public string Title => "C# mobile developer, community enthusiast, Microsoft & Xamarin MVP.";
        public string StateOrRegion => "Curitiba, Brasil";
        public string TwitterHandle => "williamsrodz";
        public string EmailAddress => "ping@williamsrz.com.br";
        public string GravatarHash => "c8f3160f0a24c13821d14b8848d62cea";
        DateTime IAmAMicrosoftMVP.FirstAwarded => new DateTime(2016, 4, 1);
        DateTime IAmAXamarinMVP.FirstAwarded => new DateTime(2016, 5, 27);
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