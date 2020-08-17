using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation.diagramViews.sequenceDiagramView
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
            cm.MenuItems.Add(save);
            return cm;
}
    }
}
