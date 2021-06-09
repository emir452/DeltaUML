
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SequenceDiagramService.Core;
using DeltaUMLSdk;
namespace SequenceDiagramService.Presentation
{
    public partial class SequenceDiagramControl :  CustomControl
    {
        private FRMObjectViewer objectViewer;
        private FRMInteractionViewer interactionViewer;
                public SequenceDiagram sd { get;}

        public SequenceDiagramControl(SequenceDiagram sd)
        {
            this.sd = sd;
             objectViewer= new FRMObjectViewer(sd.objectDeclarations);
            interactionViewer = new FRMInteractionViewer(sd.interactionDetails, sd.objectDeclarations);
            this.ContextMenu =new ContextMenuManager(this).CreateMenu();
            InitializeComponent();
            
        }
        private void  BtnOvjectsViewer_click(object sender, EventArgs e)
        {
            objectViewer.Visible=true;
}
        private void  BtnInteractionsViewer_click(object sender, EventArgs e)
        {
            interactionViewer.Visible = true;
}
    }
}
