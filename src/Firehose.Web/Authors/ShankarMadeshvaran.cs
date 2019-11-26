using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors{ 
public class ShankarMadeshvaran : IAmACommunityMember , IFilterMyBlogPosts 
{  
  public string FirstName => "Shankar";
  public string LastName => "Madeshvaran";
  public string StateOrRegion => "TamilNadu, India";
  public string EmailAddress => "shankarmadeshvaran@gmail.com";
  public string ShortBioOrTagLine => "Software engineer";
  public Uri WebSite => new Uri("https://medium.com/@shankarmadeshvaran");
  public IEnumerable<Uri> FeedUris  
  {   
  get 
  { 
  yield return new Uri("https://medium.com/feed/@shankarmadeshvaran"); }
  }
  public string TwitterHandle => "Shankar__am";
  public string GravatarHash => "73d50d0d62915195ae83b87eebb523bc";  
  public string GitHubHandle => "shankarmadeshvaran";  
  public GeoPosition Position => new GeoPosition(11.030430, 76.940400);
  public string FeedLanguageCode => "en";
 }  
 public bool Filter(SyndicationItem item)    
 {                
 return item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("xamarin")) ?? false;    
 }
}
