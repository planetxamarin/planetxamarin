using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
    public class JohnMiller : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "John";

        public string LastName => "Miller";

        public string StateOrRegion => "Pennsylvania, USA";

        public string EmailAddress => "";

        public string ShortBioOrTagLine => string.Empty;

        public Uri WebSite => new Uri("http://jmillerdev.net");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://jmillerdev.net/rss"); }
        }

        public string TwitterHandle => "jmillerdev";


        public string GravatarHash => "116669ac5e3589d5a5d404e47c32aa72";
        public string GitHubHandle => string.Empty;
    }
}