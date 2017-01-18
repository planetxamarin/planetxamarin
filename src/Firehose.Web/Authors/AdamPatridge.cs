using Firehose.Web.Infrastructure;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
    public class AdamPatridge : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Adam";
        public string LastName => "Patridge";
        public string StateOrRegion => "Cheyenne, WY";
        public string TwitterHandle => "patridgedev";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => "Content Developer 2";
        public string GravatarHash => "29f7fb03af5c354d6098f0300114056b";
        public DateTime Started => new DateTime(2016, 05, 23); 
        public Uri WebSite => new Uri("http://www.patridgedev.com/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.patridgedev.com/feed/"); }
        }
        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}