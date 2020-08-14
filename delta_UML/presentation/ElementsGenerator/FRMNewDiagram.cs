using core.common;
using core.diagrams;
using core.diagrams.diagramCreators;
using core.diagrams.sequenceDiagram;
using presentation.utils;
using System;
using System.Windows.Forms;
namespace presentation
{
    public partial class FRMNewDiagram : FRMCommonEvents
    {
        private CustomTreeNode parentNode;
        private FRMProgectView fpv;
        public FRMNewDiagram(CustomTreeNode parentNode, FRMProgectView fpv)
        {
            fpv.Visible = false;
            InitializeComponent();
            this.parentNode = parentNode;
            this.fpv = fpv;
        }
         public override void ExitForm(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== Convert.ToChar(Keys.Escape))
            {
                fpv.Visible = true;
                this.Dispose();
            }

        }
        private void BtnCreateDiagram_click(object sender, EventArgs e)
        {

            if (cboSelectDiagrams.SelectedIndex == 0)
            {
                ClassDiagram cd = this.createClassDiagram();
                parentNode.leaf.Add(cd);
                this.AddDiagramToScreen(cd);
                fpv.AddDiagramControlInPanel(FormManager.GetInstance().CreateClasDiagramView(cd));
                fpv.Visible = true;
                this.Dispose();
            }
            if (cboSelectDiagrams.SelectedIndex == 1)
            {
                try
                {
                    SequenceDiagram sd = this.CreateSequenceDiagram();
                    parentNode.leaf.Add(sd);
                    this.AddDiagramToScreen(sd);
                    fpv.AddDiagramControlInPanel(FormManager.GetInstance().CreateSequenceDiagramView(sd, fpv));
                    fpv.Visible = true;
                    this.Dispose();
                }
                catch (System.UnauthorizedAccessException)
                {
                    this.ControlUnautoricedAcesException();
                }

            }
            if (cboSelectDiagrams.SelectedIndex < 0)
            {
                MessageBox.Show("no eligió nada", "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ControlUnautoricedAcesException()
        {
            MessageBox.Show("la aplicación no tiene acceso al sistema de archivos, por favor, consulte a su administrador", "error en el permiso de acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fpv.Visible = true;
            this.Dispose();

        }
        private SequenceDiagram CreateSequenceDiagram()
        {
            return (SequenceDiagram)new SequenceDiagramCreationStrategi().CreateDiagram(parentNode.leaf.GetPath(), this.txtDiagramName.Text);

        }
        private void AddDiagramToScreen(IComposite leaf)
        {
            parentNode.Nodes.Add(new CustomTreeNode(leaf));
        }
        private ClassDiagram createClassDiagram()
        {
            return (ClassDiagram)new ClassDiagramCreationStrategi().CreateDiagram(parentNode.leaf.GetPath(), this.txtDiagramName.Text);

        }
    }
}
