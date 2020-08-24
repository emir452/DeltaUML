using SequenceDiagramService.Persistence;
using System;
using System.Collections.Generic;
using DeltaUMLSdk;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SequenceDiagramService.Presentation
{
    class ContextMenuManager : INodeContextMenu
    {
        private SequenceDiagramControl control;
        public ContextMenuManager(SequenceDiagramControl  control)
        {
            this.control = control;
        }
        public ContextMenu CreateMenu()
        {
       ContextMenu cm = new ContextMenu();
            MenuItem save = new MenuItem();
            save.Text = "guardar";
            save.Click += new EventHandler(Save_click);
            cm.MenuItems.Add(save);
            return cm;
}
        private void Save_click(object sender, EventArgs e)
        {
            new SequenceDiagramDao().WriteDiagram(control.sd);
        }
    }
}
