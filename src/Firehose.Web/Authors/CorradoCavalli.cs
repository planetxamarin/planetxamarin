using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class CorradoCavalli : IAmAXamarinMVP
	{
		public string FirstName => "Corrado";
		public string LastName => "Cavalli";
		public string ShortBioOrTagLine => "";
		public string StateOrRegion => "Italy";
		public string EmailAddress => "corrado@outlook.com";
		public string TwitterHandle => "corcav";
		public string GravatarHash => "";

		public Uri WebSite => new Uri("https://www.corradocavalli.com/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://feeds.feedburner.com/corradocavalli"); } }

		public string GitHubHandle => "corradocavalli";
		public GeoPosition Position => new GeoPosition(45.8353041, 9.6492825);
        public string FeedLanguageCode => "en";
	}
}