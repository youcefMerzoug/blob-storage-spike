using System;
using System.Collections.Generic;
using System.IO;

namespace BlobStorage
{
    /// <summary>
    /// Blob content and its information.
    /// </summary>
    public interface IBlob : IBlobInfo
    {
        Stream Content { get; set; }
    }

    /// <summary>
    /// Blob information.
    /// </summary>
    public interface IBlobInfo
    {
        string Path { get; set; }

        string PartitionKey { get; set; }

        string TenantId { get; set; }

        string ContentType { get; set; }

        string Hash { get; set; }

        DateTimeOffset CreatedOn { get; set; }
        DateTimeOffset ModifiedOn { get; set; }

        IDictionary<string, string> Metadata { get; set; }
        IList<string> Tags { get; set; }
    }
}
