using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
	public class ChrisRiesgo : IAmAMicrosoftMVP, IAmAXamarinMVP, IFilterMyBlogPosts
	{
		public string FirstName => "Chris";
		public string LastName => "Riesgo";
		public string ShortBioOrTagLine => "uses machines to help make the world a more magical place.";
		public string EmailAddress => "";
		public string StateOrRegion => "Nashville, TN";
		public GeoPosition Position => new GeoPosition(36.174465, -86.767960);

		public string TwitterHandle => "chrisriesgo";
		public string GravatarHash => "f2164f68df9d2592894bd9c8fdb758bc";
		public string GitHubHandle => "chrisriesgo";

		public Uri WebSite => new Uri("http://chrisriesgo.com");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("http://chrisriesgo.com/rss/"); }
		}

		public bool Filter(SyndicationItem item) =>
			item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
			item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
	}
}