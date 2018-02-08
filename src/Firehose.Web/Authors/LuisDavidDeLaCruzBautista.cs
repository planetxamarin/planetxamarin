using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class LuisDavidDeLaCruz : IAmACommunityMember
 {
    public string FirstName => "Luis David ";
    public string LastName => "De La Cruz Bautista";
    public string ShortBioOrTagLine => "Is a Xamarin & .Net Developer, C# Lover";
    public string StateOrRegion => "Tamaulipas, México";
    public string EmailAddress => "delacruz_luis@outlook.es";
    public string TwitterHandle => "Luisdavidela";
    public string GravatarHash => "ed532249149ef8211296f897bdd3a2e1";
    public string GitHubHandle => "luisdaviddela";
    public GeoPosition Position => new GeoPosition(22.319539, -97.875958);

    public Uri WebSite => new Uri("https://luisdavidxamshap.wordpress.com/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://luisdavidxamshap.wordpress.com/rss/"); } }
  }
 }
