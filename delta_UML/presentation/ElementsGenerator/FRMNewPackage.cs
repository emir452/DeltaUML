using core.progect;
using presentation.utils;
using System;
using System.Windows.Forms;
namespace presentation
{
    public partial class FRMNewPackage : FRMCommonEvents
    {
        private CustomTreeNode parentNode;
        private FRMProgectView fpv;
        public FRMNewPackage(CustomTreeNode parentNode, FRMProgectView fpv)
        {
            InitializeComponent();
            this.parentNode = parentNode;
            this.fpv = fpv;
            fpv.Visible = false;
}

        private void FRMNewPackage_load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
         public override void ExitForm(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                fpv.Visible = true;
                this.Dispose();
}
}
               private void btnCancel_click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
        }
        private void btnCreatePackage_click(object sender, EventArgs e)
        {
            PackageManager pm = new PackageManager();
            Package pkg = pm.CreatePackage(parentNode.leaf.GetPath(), txtName.Text);
            parentNode.leaf.Add(pkg);
            CustomTreeNode ctn = new CustomTreeNode(pkg);
            ctn.Text = pkg.name;
            ctn.ContextMenu = new NodeContainerContextMenu(ctn).CreateMenu();
            parentNode.Nodes.Add(ctn);
            fpv.Visible = true;
            this.Dispose();


        }
    }
}
