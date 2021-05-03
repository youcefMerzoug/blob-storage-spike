using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlobStorage
{
    /// <summary>
    /// In memory implementation of the blob service that can be used to build tests.
    /// </summary>
    public class InMemoryBlobService : BlobService
    {
        private readonly IBlobStorageProvider _currentBlobStorageProvider;
        private readonly IBlobStorageProvider _previousBlobStorageProvider;

        public InMemoryBlobService(
            IBlobStorageProvider currentBlobStorageProvider,
            IBlobStorageProvider previousBlobStorageProvider)
            : base(currentBlobStorageProvider, previousBlobStorageProvider)
        {
            _currentBlobStorageProvider = currentBlobStorageProvider;
            _previousBlobStorageProvider = previousBlobStorageProvider;
        }

        public override Task<bool> SaveBlob(IBlob blob, IBlobAdditionalContextOptions additionalContextOptions = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
