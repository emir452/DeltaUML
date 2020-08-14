using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation.utils
{
    public partial class FRMCommonEvents : Form
    {
        public FRMCommonEvents()
        {
            InitializeComponent();
        }
         public virtual void ExitForm(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Application.Restart();
            }

        }

    }
}
