using Foundatio.Storage;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace blobstorage
{
    public class AzureBlobStorage : IBlobStorage
    {
        private readonly Lazy<AzureFileStorage> _storage;

        public AzureBlobStorage(AzureBlobStorageOptions options)
        {
            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            _storage = new Lazy<AzureFileStorage>(() => 
                new AzureFileStorage(new AzureFileStorageOptions()
                {
                    ConnectionString = options.ConnectionString,
                    ContainerName = options.ContainerName
                }));
        }

        public async Task<bool> SaveBlobAsync(
            string sourcePath,
            string destinationPath,
            CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(sourcePath))
            {
                throw new ArgumentException($"'{nameof(sourcePath)}' cannot be null or whitespace.", nameof(sourcePath));
            }

            if (string.IsNullOrWhiteSpace(destinationPath))
            {
                throw new ArgumentException($"'{nameof(destinationPath)}' cannot be null or whitespace.", nameof(destinationPath));
            }

            using var stream = File.Open(sourcePath, FileMode.Open);
            return await _storage.Value.SaveFileAsync(destinationPath, stream, cancellationToken);
        }

        public async Task<int> DeleteBlobsAsync(
            string searchPattern,
            CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(searchPattern))
            {
                throw new ArgumentException($"'{nameof(searchPattern)}' cannot be null or whitespace.", nameof(searchPattern));
            }

            return await _storage.Value.DeleteFilesAsync(searchPattern, cancellationToken);
        }

        public async Task<bool> ExistsAsync(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException($"'{nameof(path)}' cannot be null or whitespace.", nameof(path));
            }

            return await _storage.Value.ExistsAsync(path);
        }

        public Task<bool> CopyBlobAsync(string path, string targetPath, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetBlobAsync(string path, string destinationPath, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<FileInfo> GetBlobInfoAsync(string path)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RenameBlobAsync(string path, string newPath, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
