using Persistence;
using DeltaUMLSdk;
using System;
namespace core.progect
{
    public class ProgectManager
    {
        public Progect CreateProgect(String newName, String newPath)
        {
            Progect newProgect = new Progect();
            newProgect.name = newName;
            newProgect.path = UtilitiManager.GetInstance().ConbinePaths(newPath, newName);
            UtilitiManager.GetInstance().dm.CreateDirectory(newProgect.path);
            return newProgect;
        }
        public Progect OpenExistinProgect(String path)
        {
            IProgectBuilder pb = new ProgectReader(path);
            pb.AddPackages();
            return pb.GetProgect();
        }

    }
}
