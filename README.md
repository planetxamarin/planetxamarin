# Welcome [![Build status](https://ci.appveyor.com/api/projects/status/lpkmo9pftmku26ck?svg=true)](https://ci.appveyor.com/project/ghuntley/planetxamarin)

Hi! Welcome to PlanetXamarin.com!

If you write about Xamarin, you belong here. You're welcome to add your blog and have it aggregated as part of our feed as long as the content you are sharing does not violate the community [code of conduct](https://github.com/planetxamarin/planetxamarin/blob/master/CODE_OF_CONDUCT.md).

# Add yourself as an author

### Author Guidelines
- I have a valid blog & RSS URL
- Host NO malicious or offensive content on the blog (including photos, swearing, etc.)
- Blog is active with at least 3 Xamarin related blog posts in the last 6 months
- If the blog has mixed content (Xamarin and Personal/Non-Xamarin blogs) a filter has been applied
- If you delete your blog you will come delete your blog from Planet Xamarin
- Your blog may be removed at any time if any of these are broken.

### How to add

To add yourself as an author you can fork this project, add yourself to the [authors folder](https://github.com/planetxamarin/planetxamarin/tree/master/src/Firehose.Web/Authors) as a class, implementing the `IAmACommunityMember` interface. If you are doing this via the GitHub editor, don't forget to _add the class to the .csproj_.

The result should look something like this:

``` csharp
public class BruceWayne : IAmACommunityMember
{
    public string FirstName => "Bruce";
    public string LastName => "Wayne";
    public string ShortBioOrTagLine => "potentially batman";
    public string StateOrRegion => "Gotham";
    public string EmailAddress => "rescueme@planetxamarin.com";
    public string TwitterHandle => "planetxamarin";
    public string GravatarHash => "42abc1337def";
    public string GitHubHandle => "planetxamarin";
    public GeoPosition Position => new GeoPosition(47.643417, -122.126083);

    public Uri WebSite => new Uri("https://planetxamarin.com/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://planetxamarin.com/rss"); } }
}
```

A few things: 
- Name the class after your first and lastname with CamelCase
- The `FirstName` and `LastName` property should resemble that same name
- `ShortBioOrTagLine` property can be whatever you like. If you can't think of anything choose: 'software engineer' or 'software engineer at Microsoft'
- `StateOrRegion` will be your geographical location, i.e.: Holland, New York, etc.
- `EmailAddress`, `TwitterHandle` and `GitHubHandle` should be pretty clear, `TwitterHandle` without the leading @
- `Position` is your latitude and longitude, this allows you to be placed on the map on the Authors page
- The `Website` property can be your global website or whatever you want people to look at
- And finally with `FeedUris` you can supply one or more URIs which resemble your blogs. Your blogs should be provided in RSS (Atom) format and of course be about Xamarin. 
- If you do not want your e-mailaddress publicly available but you _do_ want to show your Gravatar go to https://en.gravatar.com/site/check/ and get your hash! If you don't fill the hash, you will be viewed as a silhouette.
- When you are an Xamarin and/or Microsoft MVP check out the `IAmAXamarinMVP` and `IAmAMicrosoftMVP` interfaces, see below for a small sample.

``` csharp
public class DoubleMVPHuman : IAmAMicrosoftMVP, IAmAXamarinMVP
{
    public string FirstName => "Bruce";
    public string LastName => "Wayne";
    public string ShortBioOrTagLine => "potentially batman";
    public string StateOrRegion => "Gotham";
    public string EmailAddress => "rescueme@planetxamarin.com";
    public string TwitterHandle => "planetxamarin";
    public string GravatarHash => "";
    public string GitHubHandle => "planetxamarin";
    public GeoPosition Position => new GeoPosition(47.643417, -122.126083);

    public Uri WebSite => new Uri("http://www.planetxamarin.com");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://www.planetxamarin.com/feed/"); } }
}
```

This way you can have both dates implemented, if you have just one, implement just the one interface.

If you also do some blogging about other stuff, no worries! You're fine! Just have a look at the next section on how to filter out your Xamarin specific posts.

# Just Xamarin please

As you would suspect from 'PlanetXamarin', we would like to have our content about.. Xamarin. To ensure that we only get relevant content you can also implement the `IFilterMyBlogPosts` interface on your author class.

``` csharp
public class BruceWayne : IAmACommunityMember, IFilterMyBlogPosts
{
    // ... Author properties from the above class, removed for brevity

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
```

# A small step for an author...

A big step for mankind! Last thing that remains is submit a Pull Request to us and whenever it gets merged: hooray! You're an author now!

Don't forget to incorporate the Featured on Planet Xamarin badge on your blog and link back to us!


![Featured on Planet Xamarin Badge](https://www.planetxamarin.com/Content/img/planetxamarin-featured-badge.png)

Enjoy all of our great content! 

Of course you are more than welcome to submit other features and bugfixes as well.

# Acknowledgements
* Thanks to Readify for open sourcing their employee blog aggregation platform which we forked to create PlanetXamarin. Looking for your next challenge? [Readify is hiring](https://join.readify.net/?source=StaffReferral&campaign=geoffrey.huntley) and offers relocation services for developers from abroad.
* Thanks to [our awesome contributors](https://github.com/planetxamarin/planetxamarin/graphs/contributors) and our [community of authors](https://github.com/planetxamarin/planetxamarin/tree/master/src/Firehose.Web/Authors) who make this all possible.
