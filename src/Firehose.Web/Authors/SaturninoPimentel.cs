using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SaturninoPimentel : IAmAMicrosoftMVP
    {
        public string FirstName => "Saturnino";
        public string LastName => "Pimentel";
        public string StateOrRegion => "Ciudad de México";
        public string EmailAddress => "sp@saturninopimentel.com";
        public string ShortBioOrTagLine => "Saturnino Pimentel is a Microsoft MVP";
        public Uri WebSite => new Uri("https://saturninopimentel.com");
        public string TwitterHandle => "saturpimentel";
        public string GitHubHandle => "SaturninoPimentel";
        public string GravatarHash => "0e0fbf525519e59b3842b2ababdb12dd";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://saturninopimentel.com/rss/"); }
        }

        public GeoPosition Position => new GeoPosition(19.432608, -99.133209);
        public string FeedLanguageCode => "es";
    }
}