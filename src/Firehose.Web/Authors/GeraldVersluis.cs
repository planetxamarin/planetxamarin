using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class GeraldVersluis : IAmAReadifarian
    {
        public string FirstName => "Gerald";

        public string LastName => "Versluis";

        public string StateOrRegion => "Holland";

        public string EmailAddress => "gerald@verslu.is";

        public string Title => "Xamarin Developer | Microsoft MVP";

        public Uri WebSite => new Uri("https://blog.verslu.is/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.verslu.is/feed/"); }
        }

        public string TwitterHandle => "jfversluis";
    }
}