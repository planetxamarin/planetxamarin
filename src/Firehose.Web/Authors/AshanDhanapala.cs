using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AshanDhanapala : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Ashan";
        public string LastName => "Dhanapala";
        public string StateOrRegion => "Colombo, Sri Lanka";
        public string TwitterHandle => "ashanCodes";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => Xamarin Dev, Speaker and your Mobile DevOps Guy;
        public Uri WebSite => new Uri("http://www.patridgedev.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://ashancodes.wordpress.com"); }
        }

        public string GitHubHandle => "ashanCodes";

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
        public GeoPosition Position => new GeoPosition(41.1399810, -104.8202460);
    }
}
