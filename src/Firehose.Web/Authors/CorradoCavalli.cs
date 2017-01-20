using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class CorradoCavalli : IAmAXamarinMVP, IFilterMyBlogPosts
	{
		public string FirstName => "Corrado";
		public string LastName => "Cavalli";
		public string ShortBioOrTagLine => "";
		public string StateOrRegion => "Italy";
		public string EmailAddress => "corrado@outlook.com";
		public string TwitterHandle => "corcav";
		public string GravatarHash => "";

		public Uri WebSite => new Uri("http://www.corradocavalli.com/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://feeds.feedburner.com/corradocavalli"); } }

		public bool Filter(SyndicationItem item)
		{
			return item.Title.Text.ToLowerInvariant().Contains("xamarin") || item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
		}

		public string GitHubHandle => "corradocavalli";
		public GeoPosition Position => new GeoPosition(45.8353041, 9.6492825);
	}
}
