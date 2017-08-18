using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JaimeHernandez : IAmACommunityMember,IFilterMyBlogPosts
    {
        public string FirstName => "Jaime";
        public string LastName => "Hernandez";
        public string StateOrRegion => "Santiago, Chile";
        public string TwitterHandle => "HsJhernandez";
        public string EmailAddress => "jhernandez.hs@icloud.com";
        public string ShortBioOrTagLine => "Systems analyst developing web systems and mobile applications" ;
        public string GravatarHash => "35939afef20aac1680fc71bbd6d9c214";
        public Uri WebSite => new Uri("http://lawebdelprogramador.cl/bloglawebdelprogramador/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://lawebdelprogramador.cl/bloglawebdelprogramador/feed/"); }
        }
        public string GitHubHandle => "lawebdeprogramador";
        public GeoPosition Position => new GeoPosition(-33.4488897, -70.6692655);
        public bool Filter(SyndicationItem item){
		return item.Title.Text.ToLowerInvariant().Contains("xamarin");
	}
    }
}
