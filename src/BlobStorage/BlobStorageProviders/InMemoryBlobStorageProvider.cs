using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlobStorage
{
    /// <summary>
    /// In memory implementation of the blob storage provider that can be used to build tests.
    /// </summary>
    public class InMemoryBlobStorageProvider : IBlobStorageProvider
    {
        public Task<int> DeleteBlobs(string path, IBlobAdditionalContextOptions additionalContextOptions = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(string path, IBlobAdditionalContextOptions additionalContextOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetBlob(IBlob blob, IBlobAdditionalContextOptions additionalContextOptions = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IBlob> GetBlobInfo(string path, IBlobAdditionalContextOptions additionalContextOptions = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RenameBlob(string path, string newPath, IBlobAdditionalContextOptions additionalContextOptions = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveBlob(IBlob blob, IBlobAdditionalContextOptions additionalContextOptions = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
