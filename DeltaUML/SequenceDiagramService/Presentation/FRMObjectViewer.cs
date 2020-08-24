using DeltaUMLSdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SequenceDiagramService.Core;
namespace SequenceDiagramService.Presentation
{
    public partial class FRMObjectViewer : FRMCommonEvents
    {
         public  BindingList<ObjectDeclaration> objectDeclarations { get;}
        public FRMObjectViewer(IList<ObjectDeclaration> objectDeclarations)
        {
            this.objectDeclarations = new BindingList<ObjectDeclaration>(objectDeclarations);
           
            InitializeComponent();
        }
        public override void ExitForm(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Visible = false;
            }
        }
        private void SetUpDGV()
        {
            if (objectDeclarations.Count == 0)
            {
                ObjectDeclaration od = new ObjectDeclaration();
                od.objectName = "Object1";
                od.className = "Class1";
                objectDeclarations.Add(od);
            }
            dgv.DataSource = objectDeclarations;
        }

    }
   

}