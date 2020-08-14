using core.progect;
using presentation.utils;
using System;
using System.Windows.Forms;
namespace presentation
{
    public partial class FRMNewProgect : FRMCommonEvents
    {
        private string progectPath;
        public FRMNewProgect()
        {
            InitializeComponent();
        }
        private void FRMNewProgect_load(object sender, EventArgs e)
        {
            this.CenterToParent();
}
        
        private void TXTProgectName_enter(object sender, EventArgs e)
        {

        }
        private void BTNselectProgectLocation_click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                progectPath = fd.SelectedPath;
                BTNSelectProgectLocation.Text = fd.SelectedPath;

            }
        }
        private void BTNCreateProgect_click(object sender, EventArgs e)
        {
            TreeProgectView tpv = new TreeProgectView(new ProgectManager().CreateProgect(TXTProgectName.Text, progectPath));
            FormManager.GetInstance().CreateProgectView(tpv);
            this.Dispose();

        }
    }
}
