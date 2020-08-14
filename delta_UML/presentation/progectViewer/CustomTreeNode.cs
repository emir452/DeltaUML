using core.common;
using System;
using System.Windows.Forms;
namespace presentation
{
    public class CustomTreeNode : TreeNode
    {
        public IComposite leaf { get; set; }
        public CustomTreeNode(IComposite leaf)
        {
            this.leaf = leaf;
            this.Text = leaf.GetName();
            this.Name = leaf.GetName();
        }
        public Boolean IsContainerNode()
        {
            return leaf.IsPackage();
        }

    }
}
