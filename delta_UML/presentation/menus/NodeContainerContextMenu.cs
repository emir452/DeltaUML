using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace presentation

{
    class NodeContainerContextMenu : NodeContextMenu
    {
        private FormManager fm;

        public NodeContainerContextMenu(CustomTreeNode ctn)
        : base(ctn)
        {
            fm = FormManager.GetInstance();
        }
        public override ContextMenu CreateMenu()
        {
            ContextMenu cm = base.CreateMenu();
            MenuItem miNewElement = new MenuItem();
            miNewElement.Text = "nuevo";
            MenuItem miNewDiagram = new MenuItem();
            miNewDiagram.Text = "diagrama";
            miNewDiagram.Click += new EventHandler(NewDiagram_click);
            MenuItem miNewPackage = new MenuItem();
            miNewPackage.Text = "paquete";
            miNewPackage.Click += new EventHandler(miNewPackage_click);
             MenuItem miNotFunctionalRequirementsTable = new MenuItem();
            miNotFunctionalRequirementsTable.Text = "tabla de requerimientos no funcionales";
            miNotFunctionalRequirementsTable.Click += new EventHandler(MiNewNotFunctionalRequirementsTable_click);
            miNewElement.MenuItems.Add(miNewDiagram);
            miNewElement.MenuItems.Add(miNewPackage);
            miNewElement.MenuItems.Add(miNotFunctionalRequirementsTable);
            cm.MenuItems.Add(miNewElement);
            return cm;
        }
        private void MiNewNotFunctionalRequirementsTable_click(object sender, EventArgs e)
        {
            List<string> header = new List<string>();
            header.Add("Numero");
            header.Add("Nombre");
            header.Add("Descripción");
            header.Add("Características");
            header.Add("Significado para la arquitectura");
            header.Add("Explicación");
            string path =ctn.leaf.GetPath() + "/" + "prueba.xlsx";
            new core.fileGenerators.ExcelGenerator().GenerateExcel(header, path);
}
        private void miNewPackage_click(object sender, EventArgs e)
        {
            fm.CreateNewPackageForm(ctn);
        }
        private void NewDiagram_click(object sender, EventArgs e)
        {
            fm.CreateNewDiagramView(ctn);
        }


    }
}
