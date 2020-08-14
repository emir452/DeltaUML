using core.diagrams.sequenceDiagram;
using System.Drawing;
using System.Windows.Forms;
namespace presentation.diagramViews.sequenceDiagramView
{
    partial class FRMObjectViewer
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
            this.Text = "visualizador de objetos";
            this.Dock = DockStyle.Fill;
            tlp = new TableLayoutPanel();
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tlp.ColumnCount = 1;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            tlp.Dock = DockStyle.Fill;
            tlp.BackColor = Color.Blue;
            lstObjectControls = new ListView();
            lstObjectControls.Dock = DockStyle.Fill;
            btnNewObject = new Button();
            btnNewObject.Text = "nueva declaración de objeto";
            btnNewObject.Dock = DockStyle.Fill;
            btnNewObject.Click += new System.EventHandler(BtnNewObject_click);
            this.FillObjectControls();
            tlp.Controls.Add(lstObjectControls);
            this.Controls.Add(tlp);
            this.Controls.Add(btnNewObject);
        }

        #endregion
        private TableLayoutPanel tlp;
        private ListView lstObjectControls;
        private Button btnNewObject;
    }
}