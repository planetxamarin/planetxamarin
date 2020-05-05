using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class DamienAicheh : IAmACommunityMember
	{
		public string FirstName => "Damien";

		public string LastName => "Aicheh";

		public string StateOrRegion => "Rennes, France";

		public string EmailAddress => "";

		public string ShortBioOrTagLine => "is a passionate mobile developer also interrested about Azure, Azure DevOps and.NET Core.";

		public Uri WebSite => new Uri("https://damienaicheh.github.io/");

		public string TwitterHandle => "damienaicheh";

		public string GitHubHandle => "damienaicheh";

		public string GravatarHash => "b5cf688a9aa81b3ef752ecda4366a8e9";

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://damienaicheh.github.io/feed.xml"); }
		}

		public GeoPosition Position => new GeoPosition(48.1113036, -1.6801598);

		public string FeedLanguageCode => "en";
	}
}