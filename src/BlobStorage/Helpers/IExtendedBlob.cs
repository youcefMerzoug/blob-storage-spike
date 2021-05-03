using System.Collections.Generic;
using System.IO;

namespace BlobStorage
{
    // Use another interface or extension methods to easily access properties that are stored in the metadata or tags collection.
    public interface IExtendedBlob : IBlob
    {
        int Size { get; set; } // Retrive the size value from the metadata dictionary
    }
}
