using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class IoneSouzaJunior : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Ione";
		public string LastName => "Souza Junior";
		public string ShortBioOrTagLine => string.Empty;
		public string StateOrRegion => "Blumenau, Brasil";
		public string EmailAddress => "junior@ionixjunior.com.br";
		public string TwitterHandle => "ionixjunior";
		public string GitHubHandle => "ionixjunior";
		public string GravatarHash => "790726f5b5613d61926dea2e2efd4da1";
		public GeoPosition Position => new GeoPosition(-26.914236, -49.068776);

		public Uri WebSite => new Uri("https://www.ionixjunior.com.br");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.ionixjunior.com.br/rss"); } }

		public bool Filter(SyndicationItem item) =>
			item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
			item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
	}
}
