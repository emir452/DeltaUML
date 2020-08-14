using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using core.diagrams.sequenceDiagram;

namespace presentation.diagramViews.sequenceDiagramView
{
    public partial class SequenceDiagramControl : UserControl
    {
        private    UserControl  frmObjectViewer;
        private Form interaction;
        private FRMProgectView fpv;
        private SequenceDiagram sd;

        public SequenceDiagramControl(SequenceDiagram sd, FRMProgectView fpv)
        {
            this.sd = sd;
            frmObjectViewer = new FRMObjectViewer(sd.objectDeclarations);
            interaction = new InteractionDetailViewer(sd.interactionDetails, sd.objectDeclarations);
            this.fpv = fpv;
            InitializeComponent();
        }
        private void  BtnOvjectsViewer_click(object sender, EventArgs e)
        {
            fpv.AddDiagramControlInPanel(frmObjectViewer);
}
        private void  BtnInteractionsViewer_click(object sender, EventArgs e)
        {
            this.Visible = false;
            interaction.ShowDialog();
        }
    }
}
