public class AshanDhanapala : IAmACommunityMember
{
    public string FirstName => "Ashan";
    public string LastName => "Dhanapala";
    public string ShortBioOrTagLine => "Wannabe serious guy and Xamarin enthusiast";
    public string StateOrRegion => "Sri Lanka";
    public string EmailAddress => "ashandhanapala@gmail.com";
    public string TwitterHandle => "ashanCodes";
    public string GravatarHash => "fabf988b09d5dae70fb8545ca07c879e";
    public string GitHubHandle => "ashancodes";
    public GeoPosition Position => new GeoPosition(6.9271, 79.8612);

    public Uri WebSite => new Uri("http://ashancodes.blog/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://ashancodes.blog/rss"); } }
}
