using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace core
{
     public class PluginManager
    {
        private static PluginManager instance;
        private Assembly sdk;
        private IList<Assembly> plugins;
        private PluginManager()
        {
}
public static PluginManager GetInstance()
        {
if(instance==null)
            {
                instance = new PluginManager();
            }
            return instance;
        }
        
    }
}
