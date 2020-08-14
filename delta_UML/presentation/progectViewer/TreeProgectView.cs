using core.common;
using core.progect;
using System.Windows.Forms;
namespace presentation
{
    public class TreeProgectView
    {
        private TreeView tv;
        private IComposite currentProgect;

        public TreeProgectView(IComposite progect)
        {
            tv = new TreeView();
            this.currentProgect = progect;
            Progect p = (Progect)currentProgect;
            tv.Name = p.name;

        }
        public TreeView CreateView()
        {
            CustomTreeNode root = new CustomTreeNode(currentProgect);
            this.AddMenu(root);
            tv.Nodes.Add(root);
            foreach (IComposite i in currentProgect.GetElements())
            {
                CustomTreeNode ctn = new CustomTreeNode(i);
                this.AddMenu(ctn);
                root.Nodes.Add(ctn);
                if (i.IsPackage())
                {
                    this.AddNodes(ctn, i);
                }

            }
            return tv;

        }
        public void AddNodes(CustomTreeNode cn, IComposite leaf)
        {
            foreach (IComposite i in leaf.GetElements())
            {
                CustomTreeNode ctn = new CustomTreeNode(i);
                this.AddMenu(ctn);
                cn.Nodes.Add(ctn);
                if (i.IsPackage())
                {
                    this.AddNodes(ctn, i);
                }
            }
        }
        private void AddMenu(CustomTreeNode ctn)
        {
            if (ctn.IsContainerNode())
            {
                ctn.ContextMenu = new NodeContainerContextMenu(ctn).CreateMenu();
            }
            else
            {
                ctn.ContextMenu = new NodeContextMenu(ctn).CreateMenu();
            }
        }

    }
}
