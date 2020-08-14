using System.Collections.Generic;

namespace core.common
{
    public interface IComposite
    {
        void Add(IComposite leaf);
        void Remove(IComposite leaf);
        IList<IComposite> GetElements();
        bool IsPackage();
        string GetPath();
        string GetName();

    }
}
