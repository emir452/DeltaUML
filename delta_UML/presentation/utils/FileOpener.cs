using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation.utils
{
     public class FileOpener
    {
        public void OpenFile(string path)
{
            Process.Start(path);
}
    }
}
