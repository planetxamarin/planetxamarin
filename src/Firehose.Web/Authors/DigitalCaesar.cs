public class DigitalCaesar : IAmACommunityMember 
{ 
    public string FirstName => "Tony"; 
    public string LastName => "Caesar"; 
    public string ShortBioOrTagLine => "Bringing the Digital World to Life"; 
    public string StateOrRegion => "USA"; 
    public string EmailAddress => "tony@digitalcaesar.com"; 
    public string TwitterHandle => "Digital_Caesar"; 
    public string GravatarHash => "e5a95c365e8f06786d6439474bc733df"; 
    public string GitHubHandle => "digitalcaesar"; 
    public GeoPosition Position => new GeoPosition(47.643417, -122.126083); 
    public Uri WebSite => new Uri("https://digitalcaesar.com/"); 
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://digitalcaesar.com/rss"); } } 
    public FeedLanguageCode => "en"; 
} 
