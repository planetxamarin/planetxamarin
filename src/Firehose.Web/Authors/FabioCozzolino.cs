using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
	public class FabioCozzolino : IAmAMicrosoftMVP, IFilterMyBlogPosts
	{
		public string FirstName => "Fabio";
		public string LastName => "Cozzolino";
		public string ShortBioOrTagLine => "";
		public string StateOrRegion => "Italy";
		public string EmailAddress => "cozzolino.fabio@gmail.com";
		public string TwitterHandle => "fabiocozzolino";
		public string GitHubHandle => "fabiocozzolino";
		public string GravatarHash => "248f702568e52394e035c85f25546d81";

		public GeoPosition Position => new GeoPosition(41.2773300, 16.4101100);
		
		public Uri WebSite => new Uri("http://www.fabiocozzolino.eu/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://www.fabiocozzolino.eu/feed/"); } }

		public bool Filter(SyndicationItem item) =>
			item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
			item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
	}
}
