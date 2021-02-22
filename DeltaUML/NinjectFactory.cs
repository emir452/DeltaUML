using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ninject;
using Ninject.Modules;
using System.Text;
using System.Threading.Tasks;

namespace DeltaUML
{
     public class NinjectFactory : NinjectModule
    {
        private IKernel kernel;
        public NinjectFactory()
        {
            kernel = new StandardKernel();
        }
        public override void Load()
        {
            kernel.Load(Directory.GetCurrentDirectory() + "Plugins" + "Diagrams");
            kernel.Bind();

}
    }
}
