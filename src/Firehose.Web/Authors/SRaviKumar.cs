public class BruceWayne : IAmACommunityMember, IFilterMyBlogPosts
{
    public string FirstName => "S Ravi";
    public string LastName => "Kumar";
    public string Title => "Xamarin Developer | Solution Architect";
    public string StateOrRegion => "Greater Noida, India";
    public string EmailAddress => "srkrathore@gmail.com";
    public string TwitterHandle => "srkrathore";
    public string GravatarHash => "";

    public Uri WebSite => new Uri("http://err2solution.com/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://err2solution.com/feed/"); } }
    
    public bool Filter(SyndicationItem item)
    {
        // This filters out only the posts that have the "xamarin" category
        return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
    }
}
