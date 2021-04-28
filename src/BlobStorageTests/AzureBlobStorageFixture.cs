
using blobstorage;
using FluentAssertions;
using NUnit.Framework;
using System.IO;
using System.Threading.Tasks;

namespace testblobstorage
{
    public class AzureBlobStorageFixture
    {
        const string ConnectionString = "<put-your-connection-string-here>";
        const string ContainerName = "default";

        private IBlobStorage _blobStorage;

        [SetUp]
        public void Setup()
        {
            var azureBlobStorageOptions = new AzureBlobStorageOptions(ConnectionString, ContainerName);
            _blobStorage = new AzureBlobStorage(azureBlobStorageOptions);
        }

        [TearDown]
        public async Task TearDown()
        {
            var count = await _blobStorage.DeleteBlobsAsync("blobs");
        }

        [Test]
        public async Task SaveBlobAsync()
        {
            // Arrange
            var files = Directory.CreateDirectory("../../../blobs").GetFiles();

            // Act
            foreach (var file in files)
            {
                var shortPath = Path.GetRelativePath(file.Directory.Parent.FullName, file.FullName);
                await _blobStorage.SaveBlobAsync(file.FullName, shortPath);
            }

            // Assert
            foreach (var file in files)
            {
                var shortPath = Path.GetRelativePath(file.Directory.Parent.FullName, file.FullName);
                var exists = await _blobStorage.ExistsAsync(shortPath);
                exists.Should().BeTrue();
            }
        }

    }
}
