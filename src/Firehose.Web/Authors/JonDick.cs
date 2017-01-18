using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
	public class JonDick : IWorkAtXamarinOrMicrosoft
	{
		public string FirstName => "Jon";
		public string LastName => "Dick";
		public string ShortBioOrTagLine => "Senior Software Engineer at Microsoft / Xamarin";
		public string EmailAddress => "jondick@gmail.com";
		public string TwitterHandle => "redth";
		public string GravatarHash => "ad73e52d7e4d89e904e7c4cfd91fc2b9";
		public string StateOrRegion => "Ontario, Canada";
		public Uri WebSite => new Uri("http://redth.codes");

		DateTime IWorkAtXamarinOrMicrosoft.Started => new DateTime(2014, 3, 10);

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("http://redth.codes/feed/"); }
		}
	}
}
