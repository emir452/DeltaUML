using System.Windows.Forms;
using System.Drawing;
using core.diagrams;
using System.Collections.Generic;
using System;

namespace presentation
{
    partial class FRMNewDiagram
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
            this.Text = "nuevo diagrama ";
            this.BackColor = Color.Blue;
            tlp = new TableLayoutPanel();
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tlp.ColumnCount = 4;
            for (int i=0; i<4; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
}
          
            cboSelectDiagrams = new ComboBox();
            cboSelectDiagrams.Text = "elija el tipo de diagrama";
            cboSelectDiagrams.Dock = DockStyle.Fill;
            lblDiagramName = new Label();
            lblDiagramName.Text = "nombre de diagrama";
            lblDiagramName.Dock = DockStyle.Fill;
            txtDiagramName = new TextBox();
            txtDiagramName.Dock = DockStyle.Fill;
            btnCreateDiagram = new Button();
            btnCreateDiagram.Text = "crear";
            btnCreateDiagram.Click += new System.EventHandler(BtnCreateDiagram_click);
                        btnCreateDiagram.Dock = DockStyle.Fill;
            tlp.Controls.Add(cboSelectDiagrams, 0, 0);
            tlp.Controls.Add(lblDiagramName, 1, 0);
            tlp.Controls.Add(txtDiagramName, 2, 0);
            tlp.Controls.Add(btnCreateDiagram, 3, 0);
            this.FillCboSelectDiagrams();
            this.Controls.Add(tlp);
}

        #endregion
        private TableLayoutPanel tlp;
        private ComboBox cboSelectDiagrams;
private Label lblDiagramName;
        private TextBox txtDiagramName;
        private Button btnCreateDiagram;
    }
}