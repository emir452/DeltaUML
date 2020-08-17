using Persistence;
namespace core.progect
{
    public class PackageManager
    {
        public Package CreatePackage(string parentPath, string name)
        {
            Package pkg = new Package();
            pkg.name = name;
            pkg.path = UtilitiManager.GetInstance().ConbinePaths(parentPath, name);
            UtilitiManager.GetInstance().dm.CreateDirectory(pkg.path);
            return pkg;
        }
    }
}
