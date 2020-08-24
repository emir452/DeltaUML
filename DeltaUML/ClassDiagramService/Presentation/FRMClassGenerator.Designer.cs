using System.Windows.Forms;
using System.Drawing;
using System;
namespace ClassDiagramService.Presentation
{
    partial class FRMClassGenerator
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
            this.Text = "generar clase";
            this.BackColor = Color.Blue;
            this.Location = cdv.Location;
            tlp = new TableLayoutPanel();
            tlp.RowCount = 2;
            tlp.ColumnCount = 2;
            for (int i = 0; i < 1; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            }
            lblClassName = new Label();
            lblClassName.Text = "inrese el nombre de la clase";
            txtClassName = new TextBox();
            btnAccept = new Button();
            btnAccept.Text = "aceptar";
            btnAccept.Click += new EventHandler(BtnAccept_click);
            btnCancel = new Button();
            btnCancel.Text = "cancelar";
            btnCancel.Click += new EventHandler(BtnCancel_click);
            tlp.Controls.Add(lblClassName, 0, 0);
            tlp.Controls.Add(txtClassName, 1, 0);
            tlp.Controls.Add(btnAccept, 0, 1);
tlp.Controls.Add(btnCancel, 1, 1);
                        this.Controls.Add(tlp);

        }

        #endregion
        private TableLayoutPanel tlp;
        private Label lblClassName;
        private TextBox txtClassName;
        private Button btnAccept;
        private Button btnCancel;
    }
}