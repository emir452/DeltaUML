using core.diagrams.sequenceDiagram;
using System.Drawing;
using System.Windows.Forms;
namespace presentation.diagramViews.sequenceDiagramView
{
    public class ObjectDeclarationControl : UserControl, IUpdater
    {
        private TableLayoutPanel tlp;
        private ObjectDeclaration currentDeclaration;
        private CustomTextBox ctbObjectName;
        private CustomTextBox ctbObjectClass;
        public ObjectDeclarationControl(ObjectDeclaration currentDeclaration)
        {
            this.currentDeclaration = currentDeclaration;
            tlp = new TableLayoutPanel();
            tlp.ColumnCount = 2;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tlp.BackColor = Color.Blue;
            ctbObjectName = new CustomTextBox("nombre del objeto");
            ctbObjectName.SetText(currentDeclaration.objectName);
            ctbObjectClass = new CustomTextBox("nombre de la clase");
            ctbObjectClass.SetText(currentDeclaration.className);
            tlp.Controls.Add(ctbObjectName, 0, 0);
            tlp.Controls.Add(ctbObjectClass, 1, 0);
            this.Controls.Add(tlp);

        }
        public void UpdateModel()
        {
            currentDeclaration.objectName = ctbObjectName.GetSelectedText();
            currentDeclaration.className = ctbObjectClass.GetSelectedText();
        }
    }
}
