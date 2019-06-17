using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ChrisHamons : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Chris";
        public string LastName => "Hamons";
        public string ShortBioOrTagLine => "is the lead engineer for Xamarin.Mac";

        public string StateOrRegion => "Austin, Texas";
        public string EmailAddress => "chris.hamons@xamarin.com";
        public string TwitterHandle => "IfErrThrowBrick";
        public Uri WebSite => new Uri("https://medium.com/@donblas");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://medium.com/feed/@donblas"); }
        }

        public string GravatarHash => "8fb3e7f07ea1386cefe1326b48e0e21a";
        public string GitHubHandle => "chamons";
        public GeoPosition Position => new GeoPosition(30.2671530, -97.7430610);
        public string FeedLanguageCode => "en";
    }
}