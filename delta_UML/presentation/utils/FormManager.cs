using DeltaUMLSdk;
using System.Drawing;
using System.Windows.Forms;
namespace presentation
{
    public class FormManager
    {
        private static FormManager instance;
        private Form currentForm;
        private FormManager()
        {

        }
        public static FormManager GetInstance()
        {
            if (instance == null)
            {
                instance = new FormManager();
            }
            return instance;
        }
        public void CreateNewProgectForm()
        {
            currentForm.Visible = true;
             new FRMNewProgect().ShowDialog();
        }
        public  Form CreateMain()
        {
            currentForm = new FRMMain();
            return currentForm;

        }
        public void CreateProgectView(TreeProgectView tpv)
        {
            DisposeForms();
            currentForm = new FRMProgectView(tpv);
            currentForm.ShowDialog();

        }
        public void CreateNewPackageForm(CustomTreeNode parentNode)
        {
            DisposeForms();
            new FRMNewPackage(parentNode, (FRMProgectView)currentForm).ShowDialog();

        }
        public void CreateNewDiagramView(CustomTreeNode parentNode)
        {
            new FRMNewDiagram(parentNode, (FRMProgectView)currentForm).ShowDialog();
        }
        private void DisposeForms()
        {
            foreach (Form i in Application.OpenForms)
            {
                i.Visible = false;
            }
        }
    }
}
