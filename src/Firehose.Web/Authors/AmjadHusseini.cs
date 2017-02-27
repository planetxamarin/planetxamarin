public class AmjadHusseini : IAmACommunityMember
{
    public string FirstName => "Amjad";
    public string LastName => "Al-Husseini";
    public string ShortBioOrTagLine => "A Web/Mobile lead developer @aramex | Technology enthusiastic | Body builder and Guitar player";
    public string StateOrRegion => "Jordan";
    public string EmailAddress => "amjad_h_cool@hotmail.com";
    public string TwitterHandle => "Amjad_Husseini";
    public string GravatarHash => "7eb71ff7195835154692f3fe61a0dfa8";

    public Uri WebSite => new Uri("https://amjadhusseini.com/");
    public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://amjadhusseini.com/feed"); } }
}
