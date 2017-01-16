using System;
using System.Collections.Generic;

namespace Firehose.Web.Infrastructure
{
    public interface IAmABlogger
    {
        IEnumerable<Uri> FeedUris { get; }
    }

    public interface IAmACommunityMember : IAmABlogger
    {
        string FirstName { get; }
        string LastName { get; }
        string StateOrRegion { get; }
        string EmailAddress { get; }
        string Title { get; }
        Uri WebSite { get; }
        string TwitterHandle { get; }
        string GravatarHash { get; }
    }

    public interface IWorkAtXamarin : IAmACommunityMember
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