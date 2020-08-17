using System;
using System.Collections.Generic;
namespace Persistence.folderManager
{
    public interface IDirectoryManager : IgeneralOperationsFromFileSystem
    {
        String CreateDirectory(String path);
        String GetDirectoryName(String path);
        IList<String> GetDirectories(String path);


    }
}
