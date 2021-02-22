using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ClassDiagramService.Persistence
{
internal  class FileManager : IFileManager
    {
        public IList<string> GetFiles(String path)
        {
            return Directory.EnumerateFiles(path).ToList();
        }
        public String GetFileExtension(String path)
        {
            return Path.GetExtension(path);
        }
        public String ReadFile(String path)
        {
            return new StreamReader(path).ReadToEnd();
        }
        public void CreateEmptiFile(string path)
        {
            File.Create(path).Close();

        }
        public void Copy(String source, String destination)
        {
            File.Copy(source, destination);
        }
        public void Cut(String source, String destination)
        {
            File.Move(source, destination);

        }
        public void Rename(string path, String newName)
        {
            String newPath = new FileInfo(path).Directory + @"\" + newName;
            File.Move(path, newPath);
            new FileInfo(path).Delete();
        }


        public void Delete(String path)
        {
            File.Delete(path);
        }
        public string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }

    }
}
