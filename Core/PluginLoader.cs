using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace core
{
     public class PluginLoader
    {
        private static IList<Assembly> assemblies;
public static  IList<Assembly> LoadAllPlugins()
{
if(assemblies!=null)
            {
                return assemblies;
            }
             assemblies = new List<Assembly>();
            string path = Directory.GetCurrentDirectory() + "/Plugins" + "/Diagrams";
           
            foreach (string i in Directory.EnumerateFiles(path, "*.dll"))
{
                assemblies.Add(Assembly.LoadFrom(i));
}
            return assemblies;

}
    }
}
