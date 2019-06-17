using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MahmoudAli : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Mahmoud";
        public string LastName => "Ali";
        public string StateOrRegion => "São Paulo, Brasil";
        public string EmailAddress => "muddibr@gmail.com";
        public string ShortBioOrTagLine => "Microsoft MVP";
        public Uri WebSite => new Uri("https://www.lambda3.com.br/blog");
        public string TwitterHandle => "akamud";
        public string GitHubHandle => "akamud";
        public string GravatarHash => "fc093b379c830c8105f8d15d9261a144";
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.lambda3.com.br/feed/"); } }
        public GeoPosition Position => new GeoPosition(-23.552339, -46.661393);
        public string FeedLanguageCode => "pt";

        public bool Filter(SyndicationItem item)
            => item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("xamarin")) ?? false;
    }
}