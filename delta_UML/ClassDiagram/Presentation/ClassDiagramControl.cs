using Persistence;
using core;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace ClassDiagram.Presentation

{
    public class ClassDiagramControl : UserControl
    {
        public ClassDiagram currentDiagram { get; set; }
        private IClassDiagramDao diagramWriter;
        public TextBox txtDiagramBodi { get; set; }
        private ClassDiagramViewMenuManager menuManager;
        public ClassDiagramControl(ClassDiagram diagram)
        {
            this.currentDiagram = diagram;
            this.Text = currentDiagram.GetName();
            this.Name = currentDiagram.GetName();
            this.AccessibleName = currentDiagram.GetName();
            this.menuManager = new ClassDiagramViewMenuManager(this);
            this.menuManager.AddMenu();
            this.BackColor = Color.White;
            this.Dock = DockStyle.Fill;
            this.AutoSize = true;
            diagramWriter = new ClassDiagramDao();
txtDiagramBodi = new TextBox();
            txtDiagramBodi.Multiline = true;
            txtDiagramBodi.Text = currentDiagram.bodi;
            txtDiagramBodi.WordWrap = false;
            txtDiagramBodi.ScrollBars = ScrollBars.Vertical;
            txtDiagramBodi.Dock = DockStyle.Fill;
            txtDiagramBodi.AutoSize = true;
            txtDiagramBodi.Name = currentDiagram.GetName();
            txtDiagramBodi.KeyUp += new KeyEventHandler(ManageKeyCombinations);

            this.Controls.Add(txtDiagramBodi);
            this.Focus();
        }
        private void ManageKeyCombinations(object sender, KeyEventArgs e)
        {
            int keyData = Convert.ToInt32(e.KeyData);
            if (keyData== (Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.N)))
            {
                new FRMClassGenerator(this).ShowDialog();
}
            if (keyData == (Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.S)))
{
                DialogResult dr=  this.SabeDiagram() ? MessageBox.Show("diagrama guardado con éxito") : MessageBox.Show("error en la escritura del diagrama");
}
}
        public  bool SabeDiagram()
        {
            currentDiagram.bodi = txtDiagramBodi.Text;
            try
            {
                diagramWriter.WriteDiagram(currentDiagram);
                return true;
            }
            catch(Exception)
            {
                return false;
            }

        }
        public AutoCompleteStringCollection SearchClassNames()
        {
            AutoCompleteStringCollection classNames = new AutoCompleteStringCollection();
            ;
            foreach (string i in txtDiagramBodi.Lines)
            {
                if (i.Contains("class"))
                {
                    classNames.Add(i.Replace("class", string.Empty));
                }
            }
            return classNames;
        }
        public void GenerateClass(string className)
        {
            String classBodi = "class " + className + Environment.NewLine + "{" + Environment.NewLine + "}";
            txtDiagramBodi.AppendText(classBodi);
        }


    }
}
