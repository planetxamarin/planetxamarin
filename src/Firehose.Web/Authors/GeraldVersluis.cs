using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class GeraldVersluis : IAmAMicrosoftMVP
    {
        public string FirstName => "Gerald";

        public string LastName => "Versluis";

        public string StateOrRegion => "Holland";

        public string EmailAddress => "";

        public string Title => "Xamarin Developer | Microsoft MVP";

        public Uri WebSite => new Uri("https://blog.verslu.is/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.verslu.is/feed/"); }
        }

        public string TwitterHandle => "jfversluis";

        public DateTime FirstAwarded => new DateTime(2016, 10, 1);

        public string GravatarHash => "f9d4d4211d7956ce3e07e83df0889731";
    }
}