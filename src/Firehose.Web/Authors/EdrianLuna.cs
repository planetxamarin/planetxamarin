using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class AdamPatridge : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Edrian";
        public string LastName => "Luna";
        public string StateOrRegion => "Manila, PH";
        public string EmailAddress => edrianpluna@gmail.com"";
        public string ShortBioOrTagLine => "Certified Sr. Xamarin Developer";
        public string GravatarHash => "29f7fb03af5c354d6098f0300114056b";
        public Uri WebSite => new Uri("https://edriandragneel.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://edriandragneel.com/feed/"); }
        }

        public string GitHubHandle => "manaslootbuyer";

        public GeoPosition Position => new GeoPosition(14.5995120, 120.9842200);

        public string FeedLanguageCode => "en";
    }
}
