public class UmairHassan : IAmACommunityMember
{
    public string FirstName => "Umair";
    public string LastName => "Hassan";
    public string ShortBioOrTagLine => "Xamarin Developer, MVP at C-SharpCorner, Owner & Writer at XamarinWeb.Com";
    public string StateOrRegion => "Lahore, Pakistan";
    public string EmailAddress => "umair.hassan03@gmail.com";
    public string TwitterHandle => "umairhassan03";
    public string GravatarHash => "ecc4a16874f8078faf13bb6b8e0c90db";
    public string GitHubHandle => "umair03";
    public GeoPosition Position => new GeoPosition(31.582045, 74.329376);
    public Uri WebSite => new Uri("https://xamarinweb.com/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://xamarinweb.com/blog/feed"); } }
    public FeedLanguageCode => "en";
}
