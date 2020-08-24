using core.common;
using core.diagrams;
using System.Collections.Generic;
using presentation.utils;
using System;
using System.Windows.Forms;
using DeltaUMLSdk;
using core;

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
        private void FillCboSelectDiagrams()
        {
            IList<Type> types = new DiagramLoader().LoadAvailableDiagramTypes();
if(types.Count == 0)
            {
                cboSelectDiagrams.Items.Add("no hay diagramas disponibles");
                btnCreateDiagram.Visible = false;
            }
            else
            {
                cboSelectDiagrams.DataSource = types;
            }

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
            if (cboSelectDiagrams.SelectedIndex < 0)
            {
                MessageBox.Show("no eligió nada", "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
