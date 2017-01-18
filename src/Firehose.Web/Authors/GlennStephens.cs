using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
	public class GlennStephens : IWorkAtXamarinOrMicrosoft
	{
		public string FirstName => "Glenn";

		public string LastName => "Stephens";

		public string StateOrRegion => "Sunshine Coast, Australia";

		public string EmailAddress => "";

		public string Title => "senior trainer at Xamarin University";

		public Uri WebSite => new Uri("http://www.glennstephens.com.au/tag/xamarin/");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("http://www.glennstephens.com.au/tag/xamarin/rss/"); }
		}

		public string TwitterHandle => "glenntstephens";

        public string GithubHandle => string.Empty;

		public string GravatarHash => "ffc4ec4a7133be87d2587325ac7b1d00";

		public DateTime Started => new DateTime(2014, 1, 9);

	}
}
