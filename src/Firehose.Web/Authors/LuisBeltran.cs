using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
  public class LuisBeltran : IAmAMicrosoftMVP
  {
      public string FirstName => "Luis";
      public string LastName => "Beltran";
      public string ShortBioOrTagLine => "is a passionate Mexican software community guy, who enjoys teaching, talking and helping others with Xamarin, Azure, and C#.";
      public string StateOrRegion => "Guanajuato, Mexico";
      public string EmailAddress => "luis@luisbeltran.mx";
      public string TwitterHandle => "darkicebeam";
      public string GravatarHash => "1e1d718f3c761611f1ff2540ad9d4c22";
      public string GitHubHandle => "icebeam7";
      public GeoPosition Position => new GeoPosition(20.487380, -100.952348);
      public Uri WebSite => new Uri("https://luisbeltran.mx/");
      public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://luisbeltran.mx/feed/"); } }
      public string FeedLanguageCode => "es";
  }
}
