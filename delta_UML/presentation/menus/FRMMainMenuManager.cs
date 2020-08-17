using presentation.utils;
using System;
using System.Windows.Forms;
namespace presentation
{
    class FRMMainMenuManager : IMenuManager
    {
        private FormManager fm;
        public FRMMainMenuManager()
        {
            fm = FormManager.GetInstance();
        }
        public MenuStrip CreateMenu()
        {
            MenuStrip ms = new MenuStrip();
            ToolStripMenuItem newProgect = new ToolStripMenuItem();
            newProgect.Text = "nuevo proyecto";
            newProgect.Click += new EventHandler(NewProgect_click);
            ToolStripMenuItem openExistingProgect = new ToolStripMenuItem();
            openExistingProgect.Text = "abrir proyecto existente";
            openExistingProgect.Click += new EventHandler(OpenExistingProgect_click);
            ToolStripMenuItem aboutUs = new ToolStripMenuItem();
            aboutUs.Text = "acerca de";
            aboutUs.Click += new EventHandler(AboutUs_click);
            ToolStripMenuItem exit = new ToolStripMenuItem();
            exit.Text = "salir";
            exit.Click += new EventHandler(Exit_click);
                        ToolStripMenuItem file = new ToolStripMenuItem();
            file.Text = "archivo";
            file.DropDownItems.Add(newProgect);
            file.DropDownItems.Add(openExistingProgect);
            file.DropDownItems.Add(aboutUs);
            file.DropDownItems.Add(exit);
            ms.Items.Add(file);
            return ms;
        }
        private void Exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AboutUs_click(object sender, EventArgs e)
        {
            new AboutUs().ShowDialog();
        }
        private void FileMenu_click(object sender, EventArgs e)
        {

        }
        private void NewProgect_click(object sender, EventArgs e)
        {
            fm.CreateNewProgectForm();
        }
        private void OpenExistingProgect_click(object sender, EventArgs e)
        {
            fm.CreateProgectView(new TreeProgectView(new OpenProgect().OpenExistingProgect()));
        }
    }
}
