using core.diagrams.sequenceDiagram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation.diagramViews.sequenceDiagramView
{
    public partial class FRMObjectViewer : UserControl
    {
        private List<ObjectDeclaration> lstObjectDeclarations;
        public FRMObjectViewer(List<ObjectDeclaration> objectDeclarations)
        {
             this.lstObjectDeclarations = objectDeclarations;
            InitializeComponent();
            this.Focus();
        }
        private void FillObjectControls()
        {
            if (lstObjectDeclarations.Count == 0)
            {
                lstObjectDeclarations.Add(new ObjectDeclaration());
            }
            foreach (ObjectDeclaration i in lstObjectDeclarations)
            {
                ObjectDeclarationControl  odc = new ObjectDeclarationControl(i);
                odc.Dock = DockStyle.Fill;
                lstObjectControls.Controls.Add(odc);
            }
        }
 private  void BtnNewObject_click(object ender, EventArgs e)
            {
            ObjectDeclarationControl odc = new ObjectDeclarationControl(new ObjectDeclaration());
            odc.Dock = DockStyle.Fill;
                lstObjectControls.Controls.Add(odc);
            odc.Focus();
}

}
}
