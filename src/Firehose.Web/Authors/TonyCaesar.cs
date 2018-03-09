using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
  public class TonyCaesar : IAmACommunityMember 
  { 
    public string FirstName => "Tony"; 
    public string LastName => "Caesar"; 
    public string ShortBioOrTagLine => "Bringing the Digital World to Life"; 
    public string StateOrRegion => "USA"; 
    public string EmailAddress => "tony@digitalcaesar.com"; 
    public string TwitterHandle => "Digital_Caesar"; 
    public string GravatarHash => "7c63b2b2254e3b0abf896577ab2746aa"; 
    public string GitHubHandle => "digitalcaesar"; 
    public GeoPosition Position => new GeoPosition(33.30186, -84.5541); 
    public Uri WebSite => new Uri("https://digitalcaesar.com/"); 
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://digitalcaesar.com/rss"); } } 
    public FeedLanguageCode => "en"; 
  } 
}
