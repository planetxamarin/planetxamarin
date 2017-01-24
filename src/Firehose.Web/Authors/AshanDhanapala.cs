using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class AshanDhanapala: IWorkAtXamarinOrMicrosoft
	{
		public string FirstName => "Ashan";
		public string LastName => "Dhanapala";
		public string StateOrRegion => "Colombo, Sri Lanka";
		public string TwitterHandle => "ashanCodes";
		public string EmailAddress => "ashandhanapala@gmail.com";
		public string ShortBioOrTagLine => "Blogger, Speaker, Programmer and your Mobile DevOps Guys";
		public string GravatarHash => "29f7fb03af5c354d6098f0300114056b";
		public Uri WebSite => new Uri("ashanCodes.wordpress.com");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("ashanCodes.wordpress.com/feed/"); }
		}

		public string GitHubHandle => "ashanatexilesoft";

		public bool Filter(SyndicationItem item) =>
			item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
			item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
		public GeoPosition Position => new GeoPosition(41.1399810, -104.8202460);
	}
}
