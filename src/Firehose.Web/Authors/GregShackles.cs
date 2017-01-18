using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
	public class GregShackles : IAmAMicrosoftMVP, IAmAXamarinMVP, IFilterMyBlogPosts
	{
		public string FirstName => "Greg";
		public string LastName => "Shackles";
		public string ShortBioOrTagLine => "Principal Engineer at Olo";
		public string EmailAddress => "greg@gregshackles.com";
		public string TwitterHandle => "gshackles";
		public string GravatarHash => "6d7b45031bf22823060849d494343a8c";
		public string StateOrRegion => "New York, NY";
		public Uri WebSite => new Uri("http://gregshackles.com");

		DateTime IAmAXamarinMVP.FirstAwarded => new DateTime(2013, 7, 16);
		DateTime IAmAMicrosoftMVP.FirstAwarded => new DateTime(2015, 7, 1);

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("http://gregshackles.com/rss/"); }
		}

		public bool Filter(SyndicationItem item) =>
			item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
			item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
	}
}