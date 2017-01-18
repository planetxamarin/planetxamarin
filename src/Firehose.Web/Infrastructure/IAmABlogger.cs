using System;
using System.Collections.Generic;

namespace Firehose.Web.Infrastructure
{
    public interface IAmACommunityMember
    {
        string FirstName { get; }
        string LastName { get; }
        string StateOrRegion { get; }
        string EmailAddress { get; }
        string ShortBioOrTagLine { get; }
        Uri WebSite { get; }
        string TwitterHandle { get; }
        string GitHubHandle { get; }
        string GravatarHash { get; }
        IEnumerable<Uri> FeedUris { get; }
    }

    public interface IWorkAtXamarinOrMicrosoft : IAmACommunityMember
    {
    }

    public interface IAmAXamarinMVP : IAmACommunityMember
    {
    }

    public interface IAmAMicrosoftMVP : IAmACommunityMember
    {
    }
}