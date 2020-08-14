using core.diagrams.sequenceDiagram;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace presentation.diagramViews.sequenceDiagramView
{
    public class InteractionDetailViewer :  Form, IUpdater
    { 
        private List<InteractionDetailControl> interactionDetailControls;
        private ComboBox cboObjects;
        private TableLayoutPanel tlp;
        public InteractionDetailViewer(IList<InteractionDetail> interactionDetails, IList<ObjectDeclaration> objectDeclarations)
        {
            interactionDetailControls = new List<InteractionDetailControl>();
            cboObjects = new ComboBox();
            cboObjects.DataSource = objectDeclarations;
            this.CreateInteractionDetailControls(interactionDetails);
            this.ConfigureScreen();

        }
        private void ConfigureScreen()
        {
            tlp = new TableLayoutPanel();
            tlp.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            tlp.ColumnCount = 2;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            tlp.RowCount = interactionDetailControls.Count;
            this.ResizeRows(tlp.RowCount);
        }
        private void ResizeRows(float newSize)
        {
            tlp.RowCount = Convert.ToInt32(newSize);
            tlp.RowStyles.Clear();
            for (int i = 0; i < Convert.ToInt32(newSize); i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / newSize));
            }
        }
        private void CreateInteractionDetailControls(IList<InteractionDetail> interactionDetails)
        {
            if (interactionDetails.Count == 0)
            {
                interactionDetails.Add(new InteractionDetail());
            }
            foreach (InteractionDetail i in interactionDetails)
            {
                interactionDetailControls.Add(new InteractionDetailControl(i, cboObjects));
            }
        }
        private void AddControlsToScreen(InteractionDetailControl interactionDetailControl)
        {


        }
        public void UpdateModel()
        {
            foreach (IUpdater i in interactionDetailControls)
{
                i.UpdateModel();
}
}
}
}

