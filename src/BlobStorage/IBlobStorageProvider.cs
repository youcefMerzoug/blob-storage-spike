using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlobStorage
{
    /// <summary>
    /// Blob abstraction that needs to be implemented by any storage provider to be supported by the enablon platform.
    /// </summary>
    public interface IBlobStorageProvider
    {
        Task<bool> SaveBlob(IBlob blob, IBlobAdditionalContextOptions additionalContextOptions = default, CancellationToken cancellationToken = default);
        Task<bool> GetBlob(IBlob blob, IBlobAdditionalContextOptions additionalContextOptions = default, CancellationToken cancellationToken = default);
        Task<bool> RenameBlob(string path, string newPath, IBlobAdditionalContextOptions additionalContextOptions = default, CancellationToken cancellationToken = default);
        Task<int> DeleteBlobs(string path, IBlobAdditionalContextOptions additionalContextOptions = default, CancellationToken cancellationToken = default);
        Task<IBlob> GetBlobInfo(string path, IBlobAdditionalContextOptions additionalContextOptions = default);
        Task<bool> Exists(string path, IBlobAdditionalContextOptions additionalContextOptions = default);
    }

    /// <summary>
    /// Additional options needed by legacy underlying implementations. 
    /// For example, in the case of the application server, whe files are stored in the database, we need to provide the current connection to the database so that all file actions will be done in the same transaction as the caller.
    /// </summary>
    public interface IBlobAdditionalContextOptions
    {
        IDictionary<string, object> Options { get; set; }
    }
}
