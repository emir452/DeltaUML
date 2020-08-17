using core.diagrams.sequenceDiagram;
using presentation.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation.diagramViews.sequenceDiagramView
{
    public partial class FRMInteractionViewer : FRMCommonEvents
    {
        private BindingList<InteractionDetail> interactionDetails;
        public FRMInteractionViewer(IList<InteractionDetail> interactionDetails)
        {
            this.interactionDetails = new BindingList<InteractionDetail>(interactionDetails);
            InitializeComponent();
        }
        private void SetUpDGV()
        {
            dgv.DataSource = interactionDetails;
        }
        public override void ExitForm(object sender, KeyPressEventArgs e)
        {
if(e.KeyChar==Convert.ToChar(Keys.Escape))
            {
                this.Visible = false;
            }
}

    }
}
