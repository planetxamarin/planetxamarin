using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
    public class AlbertTanure : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Albert";

        public string LastName => "Tanure";

        public string StateOrRegion => "Belo Horizonte, Brazil";

        public string EmailAddress => "tanure@live.com";

        public string ShortBioOrTagLine => "Software Engineer, C# mobile developer, community enthusiast, MTAC";

        public Uri WebSite => new Uri("http://www.codefc.com.br");

        public string TwitterHandle => "alberttanure";

        public string GitHubHandle => "tanure";

        public string GravatarHash => "599c01b9235c518d1e0b3b2a51aeac62";

        public IEnumerable<Uri> FeedUris
        {
            get
            {
                yield return new Uri("http://codefc.com.br/rss/");
            }
        }

        public GeoPosition Position => new GeoPosition(-19.912998, -43.940933);

        public bool Filter(SyndicationItem item)
        {   
            return item.Title.Text.ToLowerInvariant().Contains("xamarin") && item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}