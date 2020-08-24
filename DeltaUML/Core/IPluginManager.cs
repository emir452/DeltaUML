using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
     public interface IPluginManager
    {
        void LoadPlugins();
        void UnloadPlugins();
        void ReloadPlugins();
        Type searchTypeByName(string name);
        IList<Type> getSubTipesByTipe(Type t);

    }
}
