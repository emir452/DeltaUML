using System;
using System.Collections.Generic;
namespace ClassDiagramService.Persistence
{
    public interface IFileManager : IgeneralOperationsFromFileSystem
    {
        IList<String> GetFiles(String path);
        String GetFileExtension(String path);
        String ReadFile(String path);
        void CreateEmptiFile(string path);
        String GetFileName(string path);
    }
}
