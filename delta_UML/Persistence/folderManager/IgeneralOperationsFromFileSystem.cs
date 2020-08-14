using System;

namespace Persistence.folderManager
{
    public interface IgeneralOperationsFromFileSystem
    {
        void Copy(String source, String destination);
        void Cut(String source, String destination);
        void Rename(String path, String newName);
        void Delete(String path);
    }
}
