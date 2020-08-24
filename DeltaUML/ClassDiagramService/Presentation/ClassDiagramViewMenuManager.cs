using ClassDiagramService.Persistence;
using DeltaUMLSdk;
using System;
using System.Windows.Forms;
using System.ComponentModel.Composition;
namespace ClassDiagramService.Presentation
{
  class ClassDiagramViewMenuManager : INodeContextMenu
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
            cdv.ContextMenu=CreateMenu();
}
        
         public  ContextMenu  CreateMenu()
        {
            ContextMenu cm = new ContextMenu();
           
            MenuItem save = new MenuItem();
            save.Text = "guardar";
            save.Click += new EventHandler(SaveDiagram_click);
            MenuItem newClass = new MenuItem();
            newClass.Text = "nueva clase";
            newClass.Click += new EventHandler(NewClass_click);
            MenuItem edit = new MenuItem();
            edit.Text = "edición";
            MenuItem coppy = new MenuItem();
            coppy.Text = "copiar";
            coppy.Click += new EventHandler(Coppy_click);
            MenuItem cut = new MenuItem();
            cut.Text = "cortar";
            cut.Click += new EventHandler(Cut_click);
            MenuItem paste = new MenuItem();
            paste.Text = "pegar";
            paste.Click += new EventHandler(Paste_click);
            edit.MenuItems.Add(cut);
            edit.MenuItems.Add(coppy);
            edit.MenuItems.Add(paste);
            cm.MenuItems.Add(save);
            cm.MenuItems.Add(newClass);
            cm.MenuItems.Add(edit);
            return cm;

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
