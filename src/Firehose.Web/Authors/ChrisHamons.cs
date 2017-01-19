using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ChrisHamons : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Chris";
        public string LastName => "Hamons";
        public string ShortBioOrTagLine => "Xamarin.Mac Lead";

        public string StateOrRegion => "Austin, Texas";
        public string EmailAddress => "chris.hamons@xamarin.com";
        public string TwitterHandle => "IfErrThrowBrick";
        public Uri WebSite => new Uri("https://medium.com/@donblas");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://medium.com/feed/@donblas"); }
        }

        public string GravatarHash => "";
        public string GitHubHandle => string.Empty;
        public GeoPosition Position => GeoPosition.Empty;
    }
}