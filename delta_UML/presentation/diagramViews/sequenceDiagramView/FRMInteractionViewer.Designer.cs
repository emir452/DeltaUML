using System.Drawing;
using System.Windows.Forms;

namespace presentation.diagramViews.sequenceDiagramView
{
    partial class FRMInteractionViewer
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
            this.Dock = DockStyle.Fill;
            tlp = new TableLayoutPanel();
            tlp.ColumnCount = 1;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent));
            tlp.BackColor = Color.Blue;
            tlp.Dock = DockStyle.Fill;
            dgv = new DataGridView();
            dgv.RowHeadersVisible = true;
            dgv.ColumnCount = 3;
            dgv.Columns[0].Name = "emisor: objeto que emite el mensaje";
            dgv.Columns[1].Name = "receptor: objeto que recibe el mensaje";
            dgv.Columns[2].Name = "mensaje: el mensaje (o método) enviado";
            dgv.Dock = DockStyle.Fill;
            this.SetUpDGV();
            tlp.Controls.Add(dgv, 0, 0);
            this.Controls.Add(tlp);
        }

        #endregion
        private TableLayoutPanel tlp;
        private DataGridView dgv;
}
}