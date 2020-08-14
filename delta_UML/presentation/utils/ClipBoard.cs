using core.common;
using Persistence;
namespace presentation
{
    class ClipBoard
    {
        private CustomTreeNode sourceItem;
        private bool isCut;
        public void AdToClipBoard(CustomTreeNode sourceItem, bool isCut)
        {
            this.sourceItem = sourceItem;
            this.isCut = isCut;
        }

        public void Paste(CustomTreeNode destination)
        {
            if (sourceItem == null)
            {
                return;
            }
            if (destination.IsContainerNode())
            {
                return;
            }
            ModifiFileStructure(sourceItem.leaf, destination.leaf);
            ModifiMemoriStructure(destination.leaf);
            ModifiUIStructure(destination);

        }
        private void ModifiUIStructure(CustomTreeNode destination)
        {
            if (isCut)
            {
                sourceItem.Parent.Nodes.Remove(sourceItem);
                destination.Nodes.Add(sourceItem);
            }
            else
            {
                destination.Nodes.Add(sourceItem);
            }
        }
        private void ModifiMemoriStructure(IComposite destination)
        {
            if (isCut)
            {
                CustomTreeNode parent = (CustomTreeNode)sourceItem.Parent;
                parent.leaf.Remove(sourceItem.leaf);
                destination.Add(sourceItem.leaf);
            }
            else
            {
                destination.Add(sourceItem.leaf);
            }
        }
        private void ModifiFileStructure(IComposite source, IComposite destination)
        {
            UtilitiManager utiliti = UtilitiManager.GetInstance();
            if (source.IsPackage())
            {
                if (isCut)
                {
                    utiliti.dm.Cut(source.GetPath(), destination.GetPath());
                }
                else
                {
                    utiliti.dm.Copy(source.GetPath(), destination.GetPath());
                }
            }
            else
            {
                if (isCut)
                {
                    utiliti.fm.Cut(source.GetPath(), destination.GetPath());
                }
                else
                {
                    utiliti.fm.Copy(source.GetPath(), destination.GetPath());
                }
            }
        }
    }
}

