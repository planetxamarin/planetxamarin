namespace Firehose.Web.Authors
{
    public class DanielKrzyczkowski : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://mobileprogrammerblog.wordpress.com/feed/rss"); }
        }

        public string FirstName => "Daniel";
        public string LastName => "Krzyczkowski";
        public string StateOrRegion => "Warsaw, Poland";
        public string EmailAddress => "daniel.krzyczkowski@hotmail.com";
        public string ShortBioOrTagLine => "Focused on mobile world. He is passionate about mobile applications and devices. He loves learning new things about mobile development. Main part of these activities is to teach others about .NET Framework, C# programming language, Universal Windows Platform and Xamarin.";
        public Uri WebSite => new Uri("http://mobileprogrammer.pl");
        public string TwitterHandle => "DKrzyczkowski";
        public string GitHubHandle => "Daniel-Krzyczkowski";
        DateTime IAmAMicrosoftMVP.FirstAwarded => new DateTime(2016, 10, 1);
        public string GravatarHash => "65e521a756dff3ac3c233e58afc9ee2b";
        public GeoPosition Position => new GeoPosition(52.230878, 21.010842);
        
          public bool Filter(SyndicationItem item)
          {
            return item.Title.Text.ToLowerInvariant().Contains("Xamarin") && item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("Xamarin") || c.Name.ToLowerInvariant().Equals("xamarin"));
          }
    }
}
