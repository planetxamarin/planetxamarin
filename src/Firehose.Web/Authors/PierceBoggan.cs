public class PierceBoggan : IAmACommunityMember
{
    public string FirstName => "Pierce";
    public string LastName => "Boggan";
    public string ShortBioOrTagLine => "Program Manager, Mobile Developer Tools at Microsoft";
    public string StateOrRegion => "Massachusetts";
    public string EmailAddress => "pierce.boggan@microsfot.com";
    public string TwitterHandle => "pierceboggan";
    public string GravatarHash => "17def0c8169557554c565e2dc6e4f205";
    public string GitHubHandle => "pierceboggan";
    public GeoPosition Position => new GeoPosition(42.3601, -71.0589);
    public Uri WebSite => new Uri("https://pierceboggan.blog/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://pierceboggan.blog/rss"); } }
    public FeedLanguageCode => "en";
}
