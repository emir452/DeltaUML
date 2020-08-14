using System;
using System.Collections.Generic;
using System.IO;
namespace Persistence.folderManager
{
    public class DirectoryManager : IDirectoryManager
    {
        public String CreateDirectory(String path, string name)
        {
            System.IO.Directory.CreateDirectory(UtilitiManager.GetInstance().ConbinePaths(path, name));

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

        }
        public void Rename(String path, String newName)
        {

        }

    }
}
