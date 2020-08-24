using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace DeltaUML
{
     public class TipeDiagramLoader
    {
        private static IList<Assembly> assemblies;
public static  IList<Assembly> LoadAllPlugins()
{
             assemblies = new List<Assembly>();
            string path = Directory.GetCurrentDirectory() + "Plugins" + "Diagrams";
            foreach (string i in Directory.EnumerateFiles(path))
{
                assemblies.Add(Assembly.Load(i));
}
            return assemblies;

}
    }
}
