using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
	public class GeertVanDerCruijsen : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Geert";
		public string LastName => "van der Cruijsen";
		public string Title => "Lead consultant Mobile & CLoud @ Xpirit";
		public string EmailAddress => "";
		public string TwitterHandle => "geertvdc";
		public string GravatarHash => "ed3bedceb37c756ee04c8fad2a6b557f";
		public string StateOrRegion => "Uden, Netherlands";
		public Uri WebSite => new Uri("https://mobilefirstcloudfirst.net");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("http://mobilefirstcloudfirst.net/feed//"); }
		}

		public bool Filter(SyndicationItem item) =>
			item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
			item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
	}
}