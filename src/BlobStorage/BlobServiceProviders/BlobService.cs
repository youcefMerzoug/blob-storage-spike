using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlobStorage
{
    /// <summary>
    /// Manages blobs. It encapsulates all the knowledge and intelligence to handle blobs. 
    /// </summary>
    public class BlobService : IDisposable
    {
        private readonly IBlobStorageProvider _currentBlobStorageProvider;
        private readonly IBlobStorageProvider _previousBlobStorageProvider;

        public BlobService(
            IBlobStorageProvider currentBlobStorageProvider,
            IBlobStorageProvider previousBlobStorageProvider)
        {
            _currentBlobStorageProvider = currentBlobStorageProvider;
            _previousBlobStorageProvider = previousBlobStorageProvider;
        }

        public virtual Task<int> DeleteBlobs(string path, IBlobAdditionalContextOptions additionalContextOptions = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Exists(string path, IBlobAdditionalContextOptions additionalContextOptions = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> GetBlob(IBlob blob, IBlobAdditionalContextOptions additionalContextOptions = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IBlob> GetBlobInfo(string path, IBlobAdditionalContextOptions additionalContextOptions = null)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> RenameBlob(string path, string newPath, IBlobAdditionalContextOptions additionalContextOptions = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> SaveBlob(IBlob blob, IBlobAdditionalContextOptions additionalContextOptions = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IDisposable> MigrateBlobs()
        {
            throw new NotImplementedException();
        }

        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
