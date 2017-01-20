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
        public string ShortBioOrTagLine

            => "I love learing new technologies and helping people.";

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
