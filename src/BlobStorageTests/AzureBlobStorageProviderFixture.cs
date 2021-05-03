
using BlobStorage;
using NUnit.Framework;
using System;

namespace testblobstorage
{
    public class AzureBlobStorageProviderFixture
    {
        const string ConnectionString = "<put your connection string>";
        const string ContainerName = "default";

        private IBlobStorageProvider _blobStorage;

        [SetUp]
        public void Setup()
        {
            var azureBlobStorageOptions = new AzureBlobStorageProviderOptions() { ConnectionString = ConnectionString, ContainerName = ContainerName };
            _blobStorage = new AzureBlobStorageProvider(azureBlobStorageOptions);
        }

        [Test]
        public void SaveBlob()
        {
            //// Arrange
            //var files = Directory.CreateDirectory("../../../blobs").GetFiles();

            throw new NotImplementedException();
        }

    }
}
