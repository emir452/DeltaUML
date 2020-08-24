using System;
using System.Collections.Generic;
namespace SequenceDiagramService.Persistence
{
    public interface IDirectoryManager : IgeneralOperationsFromFileSystem
    {
        String CreateDirectory(String path);
        String GetDirectoryName(String path);
        IList<String> GetDirectories(String path);


    }
}
