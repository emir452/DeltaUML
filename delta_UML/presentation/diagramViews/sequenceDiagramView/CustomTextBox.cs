using System.Windows.Forms;
namespace presentation.diagramViews.sequenceDiagramView
{
    public class CustomTextBox : UserControl
    {
        private TableLayoutPanel tlp;
        private Label lblCustomName;
        private TextBox txtElement;
        public CustomTextBox(string customName)
        {
            tlp = new TableLayoutPanel();
            tlp.ColumnCount = 2;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            lblCustomName = new Label();
            lblCustomName.Text = customName;
            txtElement = new TextBox();
            tlp.Controls.Add(lblCustomName, 0, 0);
            tlp.Controls.Add(txtElement, 1, 0);
            this.Controls.Add(tlp);
        }
        public string GetSelectedText()
        {
            return txtElement.Text;
        }
        public void SetText(string s)
        {
            this.txtElement.Text = s;
        }
    }
}
