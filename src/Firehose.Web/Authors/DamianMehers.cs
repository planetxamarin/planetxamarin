public class DamianMehers : IAmACommunityMember
{
    public string FirstName => "Damian";
    public string LastName => "Mehers";
    public string ShortBioOrTagLine => "Independent Xamarin Developer";
    public string StateOrRegion => "Geneva, Switzerland";
    public string EmailAddress => "damian@mehers.com";
    public string TwitterHandle => "DamianMehers";
    public string GravatarHash => "42abc1337def";
    public string GitHubHandle => "DamianMehers";
    public GeoPosition Position => new GeoPosition(46.3635288,6.1860801);

    public Uri WebSite => new Uri("https://damianblog.com.com/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://damianblog.com/feed/"); } }
}
