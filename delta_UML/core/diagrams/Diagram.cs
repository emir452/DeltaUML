using core.common;
using System;
using System.Collections.Generic;
namespace core.diagrams
{
    [Serializable]
    public abstract class Diagram : Element
    {
        public override void Add(IComposite leaf)
        {
            throw new UnSuportedOperationException();
        }
        public override void Remove(IComposite leaf)
        {
            throw new UnSuportedOperationException();
        }
        public override IList<IComposite> GetElements()
        {
            throw new UnSuportedOperationException();
        }

        public override bool IsPackage()
        {
            return false;
        }

    }
}

