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
        // Here you filter out the given item by the criteria you want, i.e.
        // this filters out posts that do not have Xamarin in the title
        return item.Title.Text.ToLowerInvariant().Contains("xamarin");

        // This filters out only the posts that have the "xamarin" category
        return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));

        // Of course you can make the checks as complicated as you want and combine some stuff
        return item.Title.Text.ToLowerInvariant().Contains("xamarin") && item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
    }
}
