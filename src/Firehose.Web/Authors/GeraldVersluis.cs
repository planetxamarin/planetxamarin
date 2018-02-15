using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GeraldVersluis : IAmAMicrosoftMVP
    {
        public string FirstName => "Gerald";
        public string LastName => "Versluis";
        public string StateOrRegion => "The Netherlands";
        public string EmailAddress => "gerald@verslu.is";
        public string ShortBioOrTagLine => "builds awesome Xamarin apps, speaks, blogs, trains, writes and has this weird thing for unicorns";
        public Uri WebSite => new Uri("https://blog.verslu.is/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.verslu.is/feed/"); }
        }

        public string TwitterHandle => "jfversluis";
        public string GravatarHash => "f9d4d4211d7956ce3e07e83df0889731";
        public string GitHubHandle => "jfversluis";
        public GeoPosition Position => new GeoPosition(50.889039, 5.853717);
        public string FeedLanguageCode => "en";
    }
}