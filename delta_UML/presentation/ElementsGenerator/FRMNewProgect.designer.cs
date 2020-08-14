using System;
    using System.Windows.Forms;
using System.Drawing;
namespace presentation
{
    partial class FRMNewProgect
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
            this.Text = "nuevo proyecto";
            this.Load += new System.EventHandler(FRMNewProgect_load);
            this.BackColor = Color.Blue;
             tlp = new TableLayoutPanel();
           
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tlp.ColumnCount = 4;
            for (int i=0; i<tlp.ColumnCount; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / tlp.ColumnCount));
            }
            lblProgectName = new Label();
            lblProgectName.Text = "nombre del proyecto);";
            TXTProgectName = new TextBox();
            TXTProgectName.Enter += new EventHandler(TXTProgectName_enter);
           // TXTProgectName.KeyPress += new KeyPressEventHandler(ExitForm);
            BTNSelectProgectLocation = new Button();
            BTNSelectProgectLocation.Text = "seleccionar la ubicación del proyecto";
           // BTNSelectProgectLocation.KeyPress += new KeyPressEventHandler(ExitForm);
            BTNSelectProgectLocation.Click += new EventHandler(BTNselectProgectLocation_click);
            BTNCreateProgect = new Button();
            BTNCreateProgect.Text = "crear el proyecto";
            BTNCreateProgect.Click += new EventHandler(BTNCreateProgect_click);
           // BTNCreateProgect.KeyPress += new KeyPressEventHandler(ExitForm);
            tlp.Controls.Add(lblProgectName, 0, 0);
            tlp.Controls.Add(TXTProgectName, 1, 0);
            tlp.Controls.Add(BTNSelectProgectLocation, 2, 0);
            tlp.Controls.Add(BTNCreateProgect, 3, 0);
            this.Controls.Add(tlp);
}
#endregion
private TableLayoutPanel tlp;
        private Label lblProgectName;  
        private TextBox TXTProgectName;
        private Button BTNSelectProgectLocation;
        private Button BTNCreateProgect;


    }
}