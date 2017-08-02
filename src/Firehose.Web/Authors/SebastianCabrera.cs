using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

public class SebastianCabrera : IAmACommunityMember
{
    public string FirstName => "Sebastian";
    public string LastName => "Cabrera";
    public string ShortBioOrTagLine => "Xamarin developer";
    public string StateOrRegion => "Montevideo, Uruguay";
    public string EmailAddress => "serseb@gmail.com";
    public string TwitterHandle => "seba47";
    public string GravatarHash => "";
    public string GitHubHandle => "seba47";
    public GeoPosition Position => new GeoPosition(-34.811421, -56.209936);

    public Uri WebSite => new Uri("http://sebacabrera.com/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://http://sebacabrera.com/feed"); } }
}
