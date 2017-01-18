using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class MarcBruins : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Marc";
		public string LastName => "Bruins";
		public string ShortBioOrTagLine => "Xamarin Consultant";
		public string EmailAddress => "marc@marcbruins.nl";
		public string TwitterHandle => "MarcBruins";
		public string GravatarHash => "3795d2031be87499f76f6336ec5a3a45";

		public string StateOrRegion => "Groningen, Netherlands";
		public Uri WebSite => new Uri("http://www.marcbruins.nl");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("http://www.marcbruins.nl/feed/"); }
		}

        public bool Filter(SyndicationItem item) =>
			item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
			item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}