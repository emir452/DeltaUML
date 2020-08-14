using core.common;
using core.progect;
using System.Windows.Forms;
namespace presentation
{
    public class OpenProgect
    {
        private string path = "";
        public Progect OpenExistingProgect()
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.Description = "seleccione el proyecto a abrir";

            ProgectManager pm = new ProgectManager();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                path = fd.SelectedPath;
                if (string.IsNullOrEmpty(path))
                {
                    throw new UnSuportedOperationException();
                }
                else
                {
                    Progect currentProgect = pm.OpenExistinProgect(path);
                    return currentProgect;
                }
            }
            else
            {
                throw new CanceledOperationException();
            }

        }
    }

}
