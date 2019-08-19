using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class AhmedFouad : IAmACommunityMember , IFilterMyBlogPosts
	{
		public string FirstName => "Ahmed";

		public string LastName => "Fouad";

		public string StateOrRegion => "Vienna, Austria";

		public string EmailAddress => "ahmed.fouad.net@hotmail.com";

		public string ShortBioOrTagLine => "Hello, I’m Ahmed. I’m a software engineer with 10 years experience living in Vienna, Austria.\n" +
		                                   "I am a fan of technology, web development, and programming.\n" +
		                                   "I’m also interested in xamarin and mobile development.";

		public Uri WebSite => new Uri("https://medium.com/@csharpwriter");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://medium.com/feed/@csharpwriter"); }
		}

		public string TwitterHandle => "MCC_Ahmed";

		public string GravatarHash => "";
		public string GitHubHandle => "TheFo2sh";
		public GeoPosition Position => new GeoPosition(37.7510, -97.8220);

		public string FeedLanguageCode => "en";
		public bool Filter(SyndicationItem item)
		{
			return item.Categories.Any(c => c.Name == "xamarin");
		}
	}

}