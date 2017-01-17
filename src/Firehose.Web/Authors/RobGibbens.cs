using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

public class RobGibbens : IWorkAtXamarinOrMicrosoft
{
    public string FirstName => "Rob";
    public string LastName => "Gibbens";
    public string Title => "Manager / Trainer @ Xamarin University";
    public string StateOrRegion => "Farmington, Michigan";
    public string EmailAddress => "RobGibbens@arteksoftware.com";
    public string TwitterHandle => "RobGibbens";
    public string GravatarHash => "";
    public DateTime Started => new DateTime(2004, 01, 06);

    public Uri WebSite => new Uri("http://arteksoftware.com/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://arteksoftware.com/rss/"); } }

}
