public class Mushtaq : IAmACommunityMember
{
    public string FirstName => "Mushtaq";
    public string LastName => "M A";
    public string ShortBioOrTagLine => "xamarin dev";
    public string StateOrRegion => "Coimbatore";
    public string EmailAddress => "mushtaqat3gb@gmail.com";
    public string TwitterHandle => "androidmads";
    public string GravatarHash => "15324356";
    public string GitHubHandle => "androidmads";
    public GeoPosition Position => new GeoPosition(11.0168, 76.9558);
    public Uri WebSite => new Uri("https://www.androidmads.info/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://feeds.feedburner.com/androidmad"); } }
    public FeedLanguageCode => "en";
}
