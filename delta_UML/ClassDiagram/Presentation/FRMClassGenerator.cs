using presentation.utils;
using System;
using System.Windows.Forms;

namespace presentation.diagramViews.classDiagramView
{
    public partial class FRMClassGenerator :  FRMCommonEvents
    {
        private ClassDiagramControl cdv;
        public FRMClassGenerator(ClassDiagramControl cdv)
        {
            this.cdv = cdv;
            InitializeComponent();
        }
        public override void ExitForm(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Dispose();
            }
            }
        private void BtnAccept_click(object sender, EventArgs e)
        {
            cdv.GenerateClass(txtClassName.Text);
            this.Dispose();

        }
        private void BtnCancel_click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
