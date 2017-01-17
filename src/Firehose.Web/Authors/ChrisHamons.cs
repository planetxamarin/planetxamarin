using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class ChrisHamons : IWorkAtXamarinOrMicrosoft
    {
		public string FirstName => "Chris";
		public string LastName => "Hamons";
		public string Title => "Xamarin.Mac Lead";
		public DateTime Started => new DateTime (2014, 1, 1);

		public string StateOrRegion => "Austin, Texas";
		public string EmailAddress => "chris.hamons@xamarin.com";
		public string TwitterHandle => "IfErrThrowBrick";
		public Uri WebSite => new Uri("https://medium.com/@donblas");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri ("https://medium.com/feed/@donblas"); }
		}

		public string GravatarHash => "";
	}
}