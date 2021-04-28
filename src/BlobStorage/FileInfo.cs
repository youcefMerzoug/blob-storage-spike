using System;

namespace blobstorage
{
    public class FileInfo
    {
        public FileInfo(string path,
            DateTime created,
            DateTime modified,
            long size)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException($"'{nameof(path)}' cannot be null or whitespace.", nameof(path));
            }

            if (size < 0)
            {
                throw new ArgumentException($"'{nameof(size)}' cannot be negative integer.", nameof(size));
            }

            Path = path;
            Created = created;
            Modified = modified;
            Size = size;
        }

        public string Path { get; }
        public DateTime Created { get; }
        public DateTime Modified { get; }
        public long Size { get; }
    }
}
