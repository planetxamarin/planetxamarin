using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
	public class Telerik : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Telerik";

		public string LastName => string.Empty;

		public string StateOrRegion => "Global";

		public string EmailAddress => "telerikxamarinteam@progress.com";

		public string ShortBioOrTagLine => "Progress Telerik UI libraries equip .NET ninjas with a full arsenal of weapons to help you create beautiful, modern and future-proof applications quickly and intuitively.";

		public Uri WebSite => new Uri("https://www.telerik.com/");

		public string TwitterHandle => "telerik";

		public string GitHubHandle => "telerik";

		public string GravatarHash => string.Empty;

		public IEnumerable<Uri> FeedUris
		{
			get
			{
				yield return new Uri("https://feeds.telerik.com/blogs");
			}
		}

		// Bedford, MA Headquarters.
		public GeoPosition Position => new GeoPosition(42.512778, -71.251500);

		public string FeedLanguageCode => "en";

		public bool Filter(SyndicationItem item)
		{
			var relevantToXamarin = false;

			if (item.Title.Text.ToLowerInvariant().Contains("xamarin"))
			{
				// If the title mentions Xamarin, the topic is primarily and directly relevant.
				relevantToXamarin = true;
			}
			else if (item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("xamarin")) ?? false)
			{
				// If the categories contains Xamarin, the topic directly relevant.
				relevantToXamarin = true;
			}
			else if (item.Content.ToString().ToLowerInvariant().Contains("xamarin"))
			{
				// If the body talks about Xamarin, the topic uses Xamarin in some way (i.e. Use Azure function for Xamarin document processing).
				relevantToXamarin = true;
			}

			return relevantToXamarin;
		}
	}
}
