using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class TomaszCielecki : IAmAMicrosoftMVP
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://javiersuarezruiz.wordpress.com/feed/"); }
        }

        public string FirstName => "Javier";
        public string LastName => "Suarez";
        public string StateOrRegion => "Seville, Spain";
        public string EmailAddress => "javiersuarezruiz@hotmail.com";
        public string Title => "Software Developer";
        public Uri WebSite => new Uri("http://javiersuarezruiz.wordpress.com");
        public string TwitterHandle => "jsuarezruiz";
        public DateTime FirstAwarded => new DateTime(2014, 07, 01);
    }
}