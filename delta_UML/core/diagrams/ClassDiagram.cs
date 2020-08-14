using Persistence;
using System;
namespace core.diagrams
{
    public class ClassDiagram : Diagram
    {
        public string bodi { get; set; }
        private UtilitiManager fileSistem;
        public ClassDiagram()
        {
            fileSistem = UtilitiManager.GetInstance();
        }
        public void Write(string s)
        {
            this.bodi = s;
        }

        public String ReadDiagram()
        {
            bodi = fileSistem.fm.ReadFile(path);
            return bodi;

        }

    }

}