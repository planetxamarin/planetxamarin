using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
public class HoussemDellai : IAmACommunityMember
{
    public string FirstName => "Houssem";
    public string LastName => "Dellai";
    public string ShortBioOrTagLine => "Learning through videos";
    public string StateOrRegion => "Tunis";
    public string EmailAddress => "houssem.dellai@live.com";
    public string TwitterHandle => "HoussemDellai";
    public string GravatarHash => "135c1a6f36428ecca89d4843a1cee39b";
    public string GitHubHandle => "HoussemDellai";
    public GeoPosition Position => new GeoPosition(36.8188, 10.166);
    public Uri WebSite => new Uri("https://www.youtube.com/HoussemDellai");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.youtube.com/feeds/videos.xml?channel_id=UCCYR9GpcE3skVnyMU8Wx1kQ"); } }
    public string FeedLanguageCode => "en";
}
}
