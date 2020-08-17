using System;
using System.Collections.Generic;
using System.IO;
namespace Persistence.folderManager
{
    public class DirectoryManager : IDirectoryManager
    {
        public String CreateDirectory(String path)
        {
            System.IO.Directory.CreateDirectory(path);

            return path;
        }
        public String GetDirectoryName(String path)
        {
            return new DirectoryInfo(path).Name;
        }
        public IList<string> GetDirectories(string path)
        {
            IList<string> results = new List<string>();
            foreach (String i in Directory.EnumerateDirectories(path))
            {
                results.Add(i);
            }
            return results;
        }
        public void Copy(String source, String destination)
        {

        }
        public void Cut(String source, String destination)
        {

        }
        public void Delete(String path)
        {
            Directory.Delete(path);
        }
        public void Rename(String path, String newName)
{

        }

    }
}
