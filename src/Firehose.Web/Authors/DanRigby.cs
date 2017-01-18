using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class DanRigby : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Dan";
        public string LastName => "Rigby";
        public string ShortBioOrTagLine => "Xamarin Technical Solutions Professional";
        public DateTime Started => new DateTime(2015, 12, 1);
        public string StateOrRegion => "North Carolina";
        public string EmailAddress => "dan.rigby@xamarin.com";
        public string TwitterHandle => "DanRigby";
        public Uri WebSite => new Uri("http://danrigby.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://feeds.feedburner.com/DanRigby"); }
        }

        public string GravatarHash => "f025f772418fbcfd3a1e15a74bf0f8a4";
    }
}