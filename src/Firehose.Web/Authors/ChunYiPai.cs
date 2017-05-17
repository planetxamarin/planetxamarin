using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ChunYiPai : IAmAMicrosoftMVP
    {
        public string FirstName => "Chun Yi";
        public string LastName => "Pai";
        public string StateOrRegion => "Taipei, Taiwan";
        public string TwitterHandle => "";
        public string EmailAddress => "maduka_bor@hotmail.com";
        public string ShortBioOrTagLine => "Chun Yi Pai a Microsoft MVP, developement Azure App, Xamarin App and using Microsoft Cognitive Service to build more application";
        public string GravatarHash => "";
        public Uri WebSite => new Uri("https://dotblogs.com.tw/maduka/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://dotblogs.com.tw/maduka/rss"); }
        }

        public string GitHubHandle => "madukapai";

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
        public GeoPosition Position => new GeoPosition(25.000948, 121.520626);        
    }
}