﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlobStorage
{
    /// <summary>
    /// Amazon S3 cloud-native blob storage provider.
    /// </summary>
    public class AwsS3BlobStorageProvider : IBlobStorageProvider
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
