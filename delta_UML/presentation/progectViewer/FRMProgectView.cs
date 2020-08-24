using presentation.utils;
using DeltaUMLSdk;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace presentation
{
    public partial class FRMProgectView : FRMCommonEvents
    {
        public FRMProgectView(TreeProgectView tpv)
        {
            InitializeComponent(tpv);
            this.addMenu(new FRMMainMenuManager().CreateMenu());
        }
        private void addMenu(MenuStrip ms)
        {
            this.Controls.Add(ms);
        }
        public void GetTree(TreeView tv)
        {
            this.tv = tv;
        }
        private void RemoveUnexpectedControls()
        {
foreach( Control i in tlp.Controls)
            {
                if (i.GetType().Equals(typeof(UserControl)))
{
                    tlp.Controls.Remove(i);
                }
}
}
        public void AddDiagramControlInPanel(UserControl diagramView)
        {
            this.RemoveUnexpectedControls();
            diagramView.Dock = DockStyle.Fill;
            tlp.Controls.Add(diagramView, 1, 0);
            diagramView.Focus();
        }
        private void TreeViewNode_click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectDiagramControl();
            }
        }
        private IComposite getSelectedLeaf()
        {
            CustomTreeNode ctn = (CustomTreeNode)tv.SelectedNode;
            return (IComposite) ctn.leaf;
        }
        private void SelectDiagramControl()
        {
}
        public override void CatchShorcuts(object sender, KeyEventArgs e)
        {
            if(Convert.ToInt32(e.KeyData)==( Convert.ToInt32(Keys.Alt)+ Convert.ToInt32(Keys.Control)+Convert.ToInt32(Keys.L)))
            {
                tv.Focus();
            }
        }
        private void FrmClosing_click(object sender, CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
