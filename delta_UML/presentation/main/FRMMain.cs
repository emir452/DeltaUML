using System.Windows.Forms;

namespace presentation
{
    public partial class FRMMain : Form
    {
        public FRMMain()
        {
            InitializeComponent();
            this.addMenu(new FRMMainMenuManager().CreateMenu());
        }
        private void addMenu(MenuStrip ms)
        {
            this.Controls.Add(ms);
        }
    }
}
