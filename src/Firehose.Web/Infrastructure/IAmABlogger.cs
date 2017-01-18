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
        string GravatarHash { get; }
        IEnumerable<Uri> FeedUris { get; }
    }

    public interface IWorkAtXamarinOrMicrosoft : IAmACommunityMember
    {
        DateTime Started { get; }
    }

    public interface IAmAXamarinMVP : IAmACommunityMember
    {
        DateTime FirstAwarded { get; }
    }

    public interface IAmAMicrosoftMVP : IAmACommunityMember
    {
        DateTime FirstAwarded { get; }
    }
}