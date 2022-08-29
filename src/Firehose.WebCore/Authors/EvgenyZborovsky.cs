using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class EvgenyZborovsky : IAmAMicrosoftMVP
    {
        public string FirstName => "Evgeny";
        public string LastName => "Zborovsky";
        public string StateOrRegion => "Estonia";
        public string EmailAddress => "yuv4ik@gmail.com";
        public string ShortBioOrTagLine => "blogs, speaks, helps others and is an enthusiastic Xamarin developer.";
        public Uri WebSite => new Uri("https://evgenyzborovsky.com/");
        public IEnumerable<Uri> FeedUris
        {
            get
            {
                yield return new Uri("https://evgenyzborovsky.com/tag/xamarin-forms/feed/");
                yield return new Uri("https://evgenyzborovsky.com/tag/xamarin/feed/");
            }
        }
        public string TwitterHandle => "ezborovsky";
        public string GravatarHash => "b8a0ab8445fafb38afdf26cb976df32f";
        public string GitHubHandle => "yuv4ik";
        public GeoPosition Position => new GeoPosition(58.3750372, 26.6625567);
        public string FeedLanguageCode => "en";
    }
}
