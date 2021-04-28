using System.Threading;
using System.Threading.Tasks;

namespace blobstorage
{
    public interface IBlobStorage
    {
        Task<bool> SaveBlobAsync(string sourcePath, string destinationPath, CancellationToken cancellationToken = default);

        Task<bool> GetBlobAsync(string path, string destinationPath, CancellationToken cancellationToken = default);

        Task<bool> RenameBlobAsync(string path, string newPath, CancellationToken cancellationToken = default);

        Task<bool> CopyBlobAsync(string path, string targetPath, CancellationToken cancellationToken = default);

        Task<int> DeleteBlobsAsync(string searchPattern, CancellationToken cancellationToken = default);

        Task<FileInfo> GetBlobInfoAsync(string path);

        Task<bool> ExistsAsync(string path);
    }
}
