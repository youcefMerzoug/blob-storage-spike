namespace blobstorage
{
    public class AzureBlobStorageOptions
    {
        public AzureBlobStorageOptions(string connectionString, string containerName)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new System.ArgumentException($"'{nameof(connectionString)}' cannot be null or whitespace.", nameof(connectionString));
            }

            if (string.IsNullOrWhiteSpace(containerName))
            {
                throw new System.ArgumentException($"'{nameof(containerName)}' cannot be null or whitespace.", nameof(containerName));
            }

            ConnectionString = connectionString;
            ContainerName = containerName;
        }

        public string ConnectionString { get; }
        public string ContainerName { get; }
    }
}
