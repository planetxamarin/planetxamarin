# Welcome [![Build status](https://ci.appveyor.com/api/projects/status/xtmmldw1i60q2yv5?svg=true)](https://ci.appveyor.com/project/ghuntley/planetxamarin)

Hi! Welcome to PlanetXamarin.com!

If you write about Xamarin, you belong here. You're welcome to add your blog and have it aggregated as part of our feed as long as the content you are syndicating does not violate the community [code of conduct](https://github.com/ghuntley/planetxamarin/blob/master/CODE_OF_CONDUCT.md).

# Add yourself as an author

To add yourself as an author you can fork this project, add yourself to the [authors folder](https://github.com/ghuntley/planetxamarin/tree/master/src/Firehose.Web/Authors) as a class, implementing the `IAmACommunityMember` interface.

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

If you also do some blogging about other stuff, no worries! You're fine! Just have a look at the next section on how to filter out your Xamarin specific posts.

# Just Xamarin please

As you would suspect from 'PlanetXamarin', we would like to have our content about.. Xamarin. To ensure that we only get relevant content you can also implement the `IFilterMyBlogPosts` interface on your author class.

``` csharp
public class BruceWayne : IAmACommunityMember, IFilterMyBlogPosts
{
    // ... Author properties from the above class, removed for brevity

    // TODO Add some filter logic
}
```

# A small step for an author...

A big step for mankind! Last thing that remains is submit a Pull Request to us and whenever it gets merged: hooray! You're an author now!

Enjoy all of our great content! 

Of course you are more than welcome to submit other features and bugfixes as well.

# Acknowledgements
* Thanks to Readify for open sourcing their employee blog aggregation platform which we forked to create PlanetXamarin. Looking for your next challenege? [Readify is hiring](https://join.readify.net/?source=StaffReferral&campaign=geoffrey.huntley
) and offers relocation services for developers from abroad.
* Thanks to [our awesome contributors](https://github.com/ghuntley/planetxamarin/graphs/contributors) and our [community of authors](https://github.com/ghuntley/planetxamarin/tree/master/src/Firehose.Web/Authors) who make this all possible.
