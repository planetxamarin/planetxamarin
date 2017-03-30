
    public class BryanAnthonyGarcia : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Bryan Anthony";
        public string LastName => "Garcia";
        public string StateOrRegion => "Manila, Philippines";
        public string GitHubHandle => "mindofai";
        public string TwitterHandle => "mindofai";
        public string EmailAddress => "bryananthonygarcia@live.com";
        public string ShortBioOrTagLine => "Bryan Anthony Garcia is a Mobile .NET Developer who enjoys learning and writing about Mobile .NET stuff and has passion for basketball and football. Co-leads Xamarin Mobile Developers - Philippines";
        public string GravatarHash => "29f7fb03af5c354d6098f0300114056b";
        public Uri WebSite => new Uri("https://mindofai.github.io/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://mindofai.github.io/feed.xml"); }
        }


        public GeoPosition Position => new GeoPosition(14.668896, 120.947204);
    }
