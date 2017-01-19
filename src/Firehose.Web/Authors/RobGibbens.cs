using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

public class RobGibbens : IWorkAtXamarinOrMicrosoft
{
    public string FirstName => "Rob";
    public string LastName => "Gibbens";
    public string ShortBioOrTagLine => "manager and trainer at Xamarin University";
    public string StateOrRegion => "Farmington, Michigan";
    public string EmailAddress => "RobGibbens@arteksoftware.com";
    public string TwitterHandle => "RobGibbens";
    public string GravatarHash => "";
    public string GitHubHandle => string.Empty;
    public GeoPosition Position => new GeoPosition(42.4644800, -83.3763220);

    public Uri WebSite => new Uri("http://arteksoftware.com/");

    public IEnumerable<Uri> FeedUris
    {
        get { yield return new Uri("http://arteksoftware.com/rss/"); }
    }
}