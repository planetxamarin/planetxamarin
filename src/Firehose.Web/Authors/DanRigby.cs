using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DanRigby : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Dan";
        public string LastName => "Rigby";
        public string ShortBioOrTagLine => "is a Xamarin Technical Solutions Professional at Microsoft.";
        public string StateOrRegion => "Raleigh, North Carolina";
        public string EmailAddress => "Dan.Rigby@Xamarin.com";
        public string TwitterHandle => "DanRigby";
        public string GitHubHandle => "DanRigby";
        public string GravatarHash => "f025f772418fbcfd3a1e15a74bf0f8a4";
        public GeoPosition Position => new GeoPosition(35.7795900,-78.6381790);
        public Uri WebSite => new Uri("http://danrigby.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://feeds.feedburner.com/DanRigby"); }
        }
    }
}
