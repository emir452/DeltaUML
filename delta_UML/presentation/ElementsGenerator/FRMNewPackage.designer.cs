using System.Windows.Forms;
using System.Drawing;

namespace presentation
{
    partial class FRMNewPackage
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "nuevo paquete";
            this.BackColor = Color.Blue;
            this.Load += new System.EventHandler(FRMNewPackage_load);
            tlp = new TableLayoutPanel();
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tlp.ColumnCount = 3;
            for (int i = 0; i < 3; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33f));
            }
            txtName = new TextBox(); ;
             btnCreatePackage = new Button();
            btnCreatePackage.Text = "crear";
            btnCreatePackage.Click += new System.EventHandler(btnCreatePackage_click);
            btnCancel = new Button();
            btnCancel.Text="cancelar";
            btnCancel.Click += new System.EventHandler(btnCancel_click);
            tlp.Controls.Add(txtName, 0, 0);
            tlp.Controls.Add(btnCreatePackage, 1, 0);
            tlp.Controls.Add(btnCancel, 2, 0);
            this.Controls.Add(tlp);
            

        }

        #endregion
        private TableLayoutPanel tlp;
        private TextBox txtName;
        private Button btnCreatePackage;
        private Button btnCancel;
    }
}