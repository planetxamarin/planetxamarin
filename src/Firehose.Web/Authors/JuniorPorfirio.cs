using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;
using System.Linq;

namespace Firehose.Web
{
	public class JuniorPorfirio : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string EmailAddress => "juniorporfirio@gmail.com";
		public string FirstName => "Junior";
		public string GitHubHandle => "juniorporfirio";
		public string GravatarHash => "cc6a0796549f7eab6d3db20a3afa3148";
		public string LastName => "Porfirio";
		public GeoPosition Position => new GeoPosition(-22.907104, -47.063240);
		public string ShortBioOrTagLine => "loves develop codes C# and talk /write about Xamarin";
		public string StateOrRegion => "Campinas, Brasil";
		public string TwitterHandle => "juniorporfirio";
		public Uri WebSite => new Uri("http://www.juniorporfirio.com.br");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://www.juniorporfirio.com.br/rss"); } }
        public bool Filter(SyndicationItem item) => item.Title.Text.Contains("xamarin") || item.Categories.Any(c => c.Name.ToLowerInvariant().Contains("xamarin"));
    }
}
