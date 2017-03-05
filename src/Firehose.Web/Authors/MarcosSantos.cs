using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarcosSantos : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Marcos";
        public string LastName => "Barchiki dos Santos";
        public string ShortBioOrTagLine => string.Empty;
        public string StateOrRegion => "Colombo, Brasil";
        public string EmailAddress => "mhbsti@gmail.com";
        public string TwitterHandle => "mhbsantos";
        public string GitHubHandle => "mhbsti";
        public string GravatarHash => "ec11acf314f3c83e09f790891d411162";
        public GeoPosition Position => new GeoPosition(-25.292939, -49.226630);
        
        public Uri WebSite => new Uri("http://www.mhbs.com.br");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://www.mhbs.com.br/rss"); } }

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}