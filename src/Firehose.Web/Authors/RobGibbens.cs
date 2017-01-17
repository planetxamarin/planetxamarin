public class RobGibbens : IWorkAtXamarinOrMicrosoft
{
    public string FirstName => "Rob";
    public string LastName => "Gibbens";
    public string Title => "Manager / Trainer @ Xamarin University";
    public string StateOrRegion => "Farmington, Michigan";
    public string EmailAddress => "RobGibbens@arteksoftware.com";
    public string TwitterHandle => "RobGibbens";
    public string GravatarHash => "";

    public Uri WebSite => new Uri("http://arteksoftware.com/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://arteksoftware.com/rss/"); } }
}
