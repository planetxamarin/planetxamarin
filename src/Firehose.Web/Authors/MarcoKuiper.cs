using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarcoKuiper : IAmACommunityMember
	{
		public string FirstName => "Marco";
		public string LastName => "Kuiper";
		public string ShortBioOrTagLine => "is a Code monkey, incurably optimistic, loves great design and passionate about Xamarin.";
		public string StateOrRegion => "The Netherlands";
		public string EmailAddress => "";
		public string TwitterHandle => "marcofolio";
		public string GravatarHash => "5982941cf85cecc8254ec2a4f1c812ff";
		public string GitHubHandle => "marcofolio";
		public GeoPosition Position => new GeoPosition(51.987642, 5.904598);
		public Uri WebSite => new Uri("https://www.marcofolio.net/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://feeds2.feedburner.com/marcofolio"); } }
        public string FeedLanguageCode => "en";
    }
}