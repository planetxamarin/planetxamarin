using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class MatthewSoucoup : IAmAMicrosoftMVP, IAmAXamarinMVP
	{
		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://codemilltech.com/feed/"); }
		}

		public string FirstName => "Matthew";
		public string LastName => "Soucoup";
		public string StateOrRegion => "Madison, WI";
		public string EmailAddress => "msoucoup@codemilltech.com";
		public string Title => "Principal";
		public Uri WebSite => new Uri("https://codemilltech.com");
		public string TwitterHandle => "codemillmatt";
		public DateTime FirstAwarded => new DateTime(2016, 1, 1);
		public string GravatarHash => "df69069a0bffd2dae5a8700a1bef7bfd";

		DateTime IAmAXamarinMVP.FirstAwarded => new DateTime(2015, 10, 1);
		DateTime IAmAMicrosoftMVP.FirstAwarded => new DateTime(2017, 1, 1);
	}
}