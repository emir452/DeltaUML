using core.diagrams.sequenceDiagram;
using System.Windows.Forms;
namespace presentation.diagramViews.sequenceDiagramView
{
    public class InteractionDetailControl : UserControl, IUpdater
    {
        private InteractionDetail currentInteraction;
        private TableLayoutPanel tlp;
        private ComboBox cboObjectSender;
        private ComboBox cboObjectReceiber;
        private CustomTextBox ctbMethodInReceiber;
        public InteractionDetailControl(InteractionDetail currentInteraction, ComboBox cboObjects)
        {
            this.currentInteraction = currentInteraction;
            this.cboObjectSender = cboObjects;
            cboObjectSender.Text = "objeto que envía el mensaje";
            this.cboObjectReceiber = cboObjects;
            cboObjectReceiber.Text = "objeto que recibe el mensaje";
            ctbMethodInReceiber = new CustomTextBox("método invocado");
            this.ConfigureScreen();
        }
        private void ConfigureScreen()
        {
            tlp = new TableLayoutPanel();
            tlp.ColumnCount = 3;
            for (int i = 0; i < 2; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33f));
            }
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tlp.Controls.Add(cboObjectSender, 0, 0);
            tlp.Controls.Add(cboObjectReceiber, 1, 0);
            tlp.Controls.Add(ctbMethodInReceiber, 2, 0);
            this.Controls.Add(tlp);
        }


        public void UpdateModel()
        {
            currentInteraction.sender = (ObjectDeclaration)cboObjectSender.SelectedItem;
            currentInteraction.receiver = (ObjectDeclaration)cboObjectReceiber.SelectedItem;

        }

    }
}
