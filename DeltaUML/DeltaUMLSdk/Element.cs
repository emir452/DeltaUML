using System;
using System.Collections.Generic;
namespace DeltaUMLSdk
{
    public class Element : IComposite
    {
        public string name { get; set; }
        public string path { get; set; }
        private IList<IComposite> leafs;
        public Element()
        {
            leafs = new List<IComposite>();
        }
        public virtual void Add(IComposite leaf)
        {
            leafs.Add(leaf);
        }
        public virtual void Remove(IComposite leaf)
        {
            leafs.Remove(leaf);
        }
        public virtual IList<IComposite> GetElements()
        {
            return leafs;
        }
        public virtual String GetPath()
        {
            return path;
        }
        public virtual string GetName()
        {
            return name;
        }
        public virtual bool IsPackage()
        {
            throw new UnSuportedOperationException();
        }

    }
}
