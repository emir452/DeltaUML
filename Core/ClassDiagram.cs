using core.diagrams;
using System;
namespace ClassDiagram.Core

{
    public class ClassDiagram : Diagram
    {
        public string bodi { get; set; }
        public ClassDiagram()
        {
            fileSistem = UtilitiManager.GetInstance();
        }
        public void Write(string s)
        {
            this.bodi = s;

}
}
}