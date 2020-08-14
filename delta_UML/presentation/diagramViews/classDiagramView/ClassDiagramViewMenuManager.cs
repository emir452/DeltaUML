using core.dao;
using System;
using System.Windows.Forms;
namespace presentation.diagramViews.classDiagramView

{
    class ClassDiagramViewMenuManager
    {

        private ClassDiagramControl cdv;
        private IClassDiagramDao diagramWriter;
        public ClassDiagramViewMenuManager(ClassDiagramControl cdv)
        {
            this.cdv = cdv;
            diagramWriter = new ClassDiagramDao();
        }
        public void AddMenu()
{
            cdv.Controls.Add(CreateMenu());
}
        
        private MenuStrip CreateMenu()
        {
            MenuStrip ms = new FRMMainMenuManager().CreateMenu();
            ToolStripMenuItem file = (ToolStripMenuItem)ms.Items[0];
            ToolStripMenuItem save = new ToolStripMenuItem();
            save.Text = "guardar";
            save.Click += new EventHandler(SaveDiagram_click);
            ToolStripMenuItem newClass = new ToolStripMenuItem();
            newClass.Text = "nueva clase";
            newClass.Click += new EventHandler(NewClass_click);
            file.DropDownItems.Add(save);
            file.DropDownItems.Add(newClass);
            ToolStripMenuItem edit = new ToolStripMenuItem();
            edit.Text = "edición";
            ToolStripMenuItem coppy = new ToolStripMenuItem();
            ToolStripMenuItem cut = new ToolStripMenuItem();
            cut.Text = "cortar";
            cut.Click += new EventHandler(Cut_click);
            coppy.Text = "copiar";
            coppy.Click += new EventHandler(Coppy_click);
            ToolStripMenuItem paste = new ToolStripMenuItem();
            paste.Text = "pegar";
            paste.Click += new EventHandler(Paste_click);
            edit.DropDownItems.Add(cut);
            edit.DropDownItems.Add(coppy);
            edit.DropDownItems.Add(paste);
            ms.Items.Clear();
            ms.Items.Add(file);
            ms.Items.Add(edit);
            return ms;
        }
        private void NewClass_click(object sender, EventArgs e)
        {
            GenerateNewClass();
        }
        public void GenerateNewClass()
        {
            new FRMClassGenerator(cdv).ShowDialog();
        }
        private void SaveDiagram_click(Object sender, EventArgs e)
        {
            SaveDiagram();
        }
        private void Cut_click(object sender, EventArgs e)
        {
            cdv.txtDiagramBodi.Cut();
        }
        private void Coppy_click(object sender, EventArgs e)
        {
            cdv.txtDiagramBodi.Copy();
        }
        private void Paste_click(object sender, EventArgs e)
        {
            cdv.txtDiagramBodi.Paste();
        }
        public void SaveDiagram()
        {
            cdv.currentDiagram.bodi = cdv.txtDiagramBodi.Text;
            diagramWriter.WriteDiagram(cdv.currentDiagram);
        }
    }
}
