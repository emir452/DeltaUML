using System.Windows.Forms;
using System.Drawing;
namespace presentation
{
    partial class FRMProgectView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(TreeProgectView tpv)
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormClosing += new FormClosingEventHandler(FrmClosing_click);
            tv = tpv.CreateView();
            tv.Dock = DockStyle.Fill;
            tv.KeyUp += new KeyEventHandler(TreeViewNode_click);
this.BackColor = Color.Blue;
tlp = new TableLayoutPanel();
            tlp.ColumnCount = 2;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75f));
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tlp.Dock = DockStyle.Fill;
            this.Text = tv.Name;
            tv.Focus();
            tlp.Controls.Add(tv, 0, 0);           
            this.Controls.Add(tlp);

}
#endregion
private TreeView tv;
        private TableLayoutPanel tlp;



    }
}