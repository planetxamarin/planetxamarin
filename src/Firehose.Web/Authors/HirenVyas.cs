using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
public class HirenVyas : IAmACommunityMember
{
    public string FirstName => "Hiren";
    public string LastName => "Vyas";
    public string ShortBioOrTagLine => "Xamarin Buddy";
    public string StateOrRegion => "Gujarat, India";
    public string EmailAddress => "hirenvyas047@live.in";
    public string TwitterHandle => "hirenvyas047";
    public string GravatarHash => "";
    public string GitHubHandle => "hirenvyas";
    public GeoPosition Position => new GeoPosition(23.027292, 72.564086);

    public Uri WebSite => new Uri("http://xamarinbuddy.blogspot.in");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://xamarinbuddy.blogspot.in/feeds/posts/default?alt=rss"); } }
}

}
