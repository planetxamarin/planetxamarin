using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Linq;

namespace Firehose.Web.Authors
{
	public class NunoHorta : IAmACommunityMember
	{
		public string FirstName => "Nuno";

		public string LastName => "Horta";

		public string StateOrRegion => "London, United Kindgom";

		public string EmailAddress => "nunobhorta@gmail.com";

		public string Title => "Xamarin Developer";

		public Uri WebSite => new Uri("https://nunobhorta.com");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://www.nunobhorta.com/feed/"); }
		}

		public string TwitterHandle => "nunobhorta";

		public string GravatarHash => "";

		public bool Filter(SyndicationItem item)
		{
			return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
		}
	}
}