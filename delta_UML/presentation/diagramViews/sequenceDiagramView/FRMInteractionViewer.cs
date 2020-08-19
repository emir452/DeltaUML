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
        private DataGridViewComboBoxColumn dgvComboObjectDeclarations;

        public FRMInteractionViewer(IList<InteractionDetail> interactionDetails, IList<ObjectDeclaration> objectDeclarations)
        {
            this.interactionDetails = new BindingList<InteractionDetail>(interactionDetails);
            dgvComboObjectDeclarations = new DataGridViewComboBoxColumn();
            dgvComboObjectDeclarations.DataSource = objectDeclarations;

                        InitializeComponent();
        }
        private void SetUpDGV()
        {
            dgv.DataSource = interactionDetails;
            DataGridViewComboBoxColumn sender =(DataGridViewComboBoxColumn) dgvComboObjectDeclarations.Clone();
sender.HeaderText = "emisor";
            sender.ToolTipText = "el objeto que envía el mensaje";

            DataGridViewComboBoxColumn receiber = (DataGridViewComboBoxColumn)dgvComboObjectDeclarations.Clone();
            receiber.HeaderText = "receptor";
            receiber.ToolTipText = "el objeto que recibe el mensaje";
            DataGridViewTextBoxColumn method = new DataGridViewTextBoxColumn();
            method.HeaderText = "mensaje";
            method.ToolTipText = "el mensaje (o método) que se envía";
            method.DataPropertyName = "METHOD";
            dgv.Columns.Add(sender);
            dgv.Columns.Add(receiber);
            dgv.Columns.Add(method);
}
        void dgvCombo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // (No need to write anything in here)
        }
        public override void ExitForm(object sender, KeyPressEventArgs e)
        {
if(e.KeyChar==Convert.ToChar(Keys.Escape))
            {
                this.Visible = false;
}
}
        private void dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
