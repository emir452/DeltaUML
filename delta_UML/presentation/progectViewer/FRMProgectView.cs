using core.common;
using core.diagrams;
using core.diagrams.sequenceDiagram;
using presentation.utils;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace presentation
{
    public partial class FRMProgectView : Form
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
            return ctn.leaf;
        }
        private void SelectDiagramControl()
        {
            try
            {
                this.AddDiagramControlInPanel(FormManager.GetInstance().CreateClasDiagramView((ClassDiagram)this.getSelectedLeaf()));
                return;
            }
            catch (InvalidCastException)
{ }
            try
            {
this.AddDiagramControlInPanel(FormManager.GetInstance().CreateSequenceDiagramView((SequenceDiagram)getSelectedLeaf(), this));
return;
}
            catch (InvalidCastException)
{ }
            try
            {
                new FileOpener().OpenFile(getSelectedLeaf().GetPath());
                return;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "problemas",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FrmClosing_click(object sender, CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
