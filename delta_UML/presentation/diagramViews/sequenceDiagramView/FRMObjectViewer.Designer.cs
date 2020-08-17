﻿using System.Drawing;
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Dock = DockStyle.Fill;
            this.Text = "Visualizador de objetos";
            tlp = new TableLayoutPanel();
            tlp.BackColor = Color.Blue;
            tlp.Dock = DockStyle.Fill;
            tlp.ColumnCount = 1;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            dgv = new DataGridView();
            dgv.ColumnCount = 2;
            dgv.Columns[0].Name = "nombre de objeto";
            dgv.Columns[1].Name = "nombre de clase";
            dgv.RowHeadersVisible = true;
            dgv.Dock = DockStyle.Fill;
            this.SetUpDGV();
tlp.Controls.Add(dgv, 0, 0);
            this.Controls.Add(tlp);

            // finisht
        }

        #endregion
        private DataGridView dgv;
        private TableLayoutPanel tlp;
    }
}