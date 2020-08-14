using core.common;
using core.diagrams.diagramCreators;
using Persistence;
using System;
namespace core.progect
{
    class ProgectReader : IProgectBuilder
    {
        private Progect currentProgect;
        private UtilitiManager utiliti;

        public ProgectReader(String path)
        {
            utiliti = UtilitiManager.GetInstance();
            currentProgect = new Progect();
            currentProgect.path = path;
            currentProgect.name = utiliti.dm.GetDirectoryName(path);
        }
        public Progect GetProgect()
        {
            return currentProgect;
        }
        public void AddPackages()
        {
            this.addDiagrams(currentProgect);
            foreach (string i in utiliti.dm.GetDirectories(currentProgect.path))
            {
                Package pkg = new Package();
                pkg.name = utiliti.dm.GetDirectoryName(i);
                pkg.path = i;
                this.addDiagrams(pkg);
                this.AddPackages(pkg);
                currentProgect.Add(pkg);
            }
        }
        private void AddPackages(Package p)
        {
            foreach (string i in utiliti.dm.GetDirectories(p.path))
            {
                Package pkg = new Package();
                pkg.name = utiliti.dm.GetDirectoryName(i);
                pkg.path = i;
                this.addDiagrams(pkg);
                this.AddPackages(pkg);
                p.Add(pkg);
            }
        }
        private void addDiagrams(IComposite leaf)
        {
            DiagramCreationContext context = new DiagramCreationContext();
            foreach (String i in utiliti.fm.GetFiles(leaf.GetPath()))
            {
                leaf.Add(context.CreateDiagram(i));
            }

        }
    }
}
