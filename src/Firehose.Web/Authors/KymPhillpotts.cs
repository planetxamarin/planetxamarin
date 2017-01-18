using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

public class KymPhillpotts : IWorkAtXamarinOrMicrosoft
{
    public string FirstName => "Kym";
    public string LastName => "Phillpotts";
    public string Title => "instructor at Xamarin University";
    public string StateOrRegion => "Melbourne, Australia";
    public string EmailAddress => "kphillpotts@gmail.com";
    public string TwitterHandle => "kphillpotts";
    public string GravatarHash => "";
    public DateTime Started => new DateTime(2004, 01, 06);

    public Uri WebSite => new Uri("http://kymphillpotts.com/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://kymphillpotts.com/rss/"); } }

}
