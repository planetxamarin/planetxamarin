# Welcome [![Build status](https://ci.appveyor.com/api/projects/status/lpkmo9pftmku26ck?svg=true)](https://ci.appveyor.com/project/ghuntley/planetxamarin)

Hi! Welcome to PlanetXamarin.com!

If you write about Xamarin, you belong here. You're welcome to add your blog and have it aggregated as part of our feed as long as the content you are sharing does not violate the community [code of conduct](https://github.com/planetxamarin/planetxamarin/blob/master/CODE_OF_CONDUCT.md).

# Add yourself as an author

To add yourself as an author you can fork this project, add yourself to the [authors folder](https://github.com/planetxamarin/planetxamarin/tree/master/src/Firehose.Web/Authors) as a class, implementing the `IAmACommunityMember` interface.

The result should look something like this:

``` csharp
public class BruceWayne : IAmACommunityMember
{
    public string FirstName => "Bruce";
    public string LastName => "Wayne";
    public string Title => "The Dark Knight";
    public string StateOrRegion => "Gotham";
    public string EmailAddress => "rescueme@batman.com";
    public string TwitterHandle => "batman";
    public string GravatarHash => "42abc1337def";

    public Uri WebSite => new Uri("https://iamthebatman.com/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://iamthebatman.com/rss"); } }
}
```

A few things: 
- Name the class after your first and lastname with CamelCase
- The `FirstName` and `LastName` property should resemble that same name
- `Title` property can be whatever you like. Most likely something like: 'Senior Developer @ Wayne Enterprises' or 'Xamarin Developer & Microsoft MVP'
- `StateOrRegion` will be your geographical location, i.e.: Holland, New York, etc.
- `EmailAddress` and `TwitterHandle` should be pretty clear, `TwitterHandle` without the leading @
- The `Website` property can be your global website or whatever you want people to look at
- And finally with `FeedUris` you can supply one or more URIs which resemble your blogs. Your blogs should be provided in RSS (Atom) format and of course be about Xamarin. 
- If you do not want your e-mailaddress publicly available but you _do_ want to show your Gravatar go to https://en.gravatar.com/site/check/ and get your hash! If you don't fill the hash, you will be viewed as a silhouette.
- When you are an Xamarin and/or Microsoft MVP check out the `IAmAXamarinMVP` and `IAmAMicrosoftMVP` interfaces and let us know when you were first awarded, see below for a small sample.

``` csharp
public class DoubleMVPGuy : IAmAMicrosoftMVP, IAmAXamarinMVP
    {
        public string FirstName => "Awesome";
        public string LastName => "Sauce";
        public string Title => "Unicorn tamer";
        public string StateOrRegion => "127.0.0.1";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "theboss";

        public Uri WebSite => new Uri("http://www.awesomesite.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://www.awesomesite.com/feed/"); } }

        DateTime IAmAMicrosoftMVP.FirstAwarded => new DateTime(2016, 4, 1);
        DateTime IAmAXamarinMVP.FirstAwarded => new DateTime(2016, 5, 27);
        public string GravatarHash => "";
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

Enjoy all of our great content! 

Of course you are more than welcome to submit other features and bugfixes as well.

# Acknowledgements
* Thanks to Readify for open sourcing their employee blog aggregation platform which we forked to create PlanetXamarin. Looking for your next challenge? [Readify is hiring](https://join.readify.net/?source=StaffReferral&campaign=geoffrey.huntley) and offers relocation services for developers from abroad.
* Thanks to [our awesome contributors](https://github.com/planetxamarin/planetxamarin/graphs/contributors) and our [community of authors](https://github.com/planetxamarin/planetxamarin/tree/master/src/Firehose.Web/Authors) who make this all possible.
