using System;
using System.Windows.Forms;

namespace presentation.diagramViews.sequenceDiagramView
{
    partial class SequenceDiagramControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            tlp = new TableLayoutPanel();
            tlp.Dock = DockStyle.Fill;
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            tlp.ColumnCount = 2;
            for(int i=0; i<=1; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
}
            btnInteractionsViewer = new Button();
            btnInteractionsViewer.Text = "visualizar interacciones";
            btnInteractionsViewer.Click += new EventHandler(BtnInteractionsViewer_click);
            btnInteractionsViewer.Dock = DockStyle.Fill;
            btnObjectsViewer = new Button();
            btnObjectsViewer.Text = "visualizar declaraciones de objeto";
            btnObjectsViewer.Click += new EventHandler(BtnOvjectsViewer_click);
            btnObjectsViewer.Dock = DockStyle.Fill;
            tlp.Controls.Add(btnObjectsViewer, 0, 0);
            tlp.Controls.Add(btnInteractionsViewer, 1, 0);
            this.Controls.Add(tlp);
            


}

        #endregion
        private TableLayoutPanel tlp;
        private Button btnInteractionsViewer;
        private Button btnObjectsViewer;
    }
}
