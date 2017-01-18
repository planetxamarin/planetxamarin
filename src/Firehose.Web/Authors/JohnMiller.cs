using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web
{
	public class JohnMiller : IWorkAtXamarinOrMicrosoft
	{
		public string FirstName => "John";

		public string LastName => "Miller";

		public string StateOrRegion => "Pennsylvania, USA";

		public string EmailAddress => "";

		public string ShortBioOrTagLine => "Senior Support Engineer";

		public Uri WebSite => new Uri("http://jmillerdev.net");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("http://jmillerdev.net/rss"); }
		}

		public string TwitterHandle => "jmillerdev";

		public DateTime Started => new DateTime(2014, 2, 1);

		public string GravatarHash => "116669ac5e3589d5a5d404e47c32aa72";
	}
}
