using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using core;
using DeltaUMLSdk;
namespace core.diagrams
{
     public class DiagramLoader
    {
        public IList<Type> LoadAvailableDiagramTypes()
{
IList<Assembly> assemblies = PluginLoader.LoadAllPlugins();
            IList<Type> types = new List<Type>();
            Type t = Assembly.LoadFrom(Directory.GetCurrentDirectory() + "/Plugins/DeltaUMLSdk.dll").GetType("DeltaUMLSdk.Diagram");
            foreach (Assembly i in assemblies)
            {
              
foreach (Type j in i.ExportedTypes)
                {
                    if (j.IsSubclassOf(t))
                    {
                        types.Add(j);
}
}
}
return types;
}
}
}
