using System;
using System.Collections.Generic;

namespace Firehose.Web.Infrastructure
{
    public interface IAmAReadifarian
    {
        string FirstName { get; }
        string LastName { get; }
        string StateOrRegion { get; }
        string EmailAddress { get; }
        string Title { get; }
        Uri WebSite { get; }
        IEnumerable<Uri> FeedUris { get; }
        string TwitterHandle { get; }
    }
}