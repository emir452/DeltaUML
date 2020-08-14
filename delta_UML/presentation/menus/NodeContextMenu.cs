using System;
using System.Windows.Forms;
namespace presentation
{
    class NodeContextMenu : INodeContextMenu
    {
        private ClipBoard currentClipboard;
        public CustomTreeNode ctn { get; }
        public NodeContextMenu(CustomTreeNode ctn)
        {
            this.ctn = ctn;
            this.currentClipboard = new ClipBoard();
        }
        public virtual ContextMenu CreateMenu()
        {
            ContextMenu cm = new ContextMenu();
            MenuItem MICut = new MenuItem();
            MICut.Text = "cortar";
            MICut.Click += new EventHandler(MICut_Clik);
            MenuItem MICopy = new MenuItem();
            MICopy.Text = "copiar";
            MICopy.Click += new EventHandler(MICopy_click);
            MenuItem MIPaste = new MenuItem();
            MIPaste.Text = "pegar";
            MIPaste.Click += new EventHandler(MIPaste_click);
            MenuItem MIRename = new MenuItem();
            MIRename.Text = "cambiar nombre";
            MenuItem MIDelete = new MenuItem();
            MIDelete.Text = "eliminar";
            cm.MenuItems.Add(MICut);
            cm.MenuItems.Add(MICopy);
            cm.MenuItems.Add(MIPaste);
            cm.MenuItems.Add(MIRename);
            cm.MenuItems.Add(MIDelete);
            return cm;
        }
        private void MICopy_click(object sender, EventArgs e)
        {
            currentClipboard.AdToClipBoard(ctn, false);
        }
        private void MICut_Clik(object sender, EventArgs e)
        {
            currentClipboard.AdToClipBoard(ctn, true);
        }
        private void MIPaste_click(object sender, EventArgs e)
        {
            currentClipboard.Paste(ctn);
        }

    }
}