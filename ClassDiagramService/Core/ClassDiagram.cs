using System;
using DeltaUMLSdk;
namespace  ClassDiagramService.Core
{
    [Serializable]
     
public class ClassDiagram : Diagram
    {
        public string bodi { get; set; }
        public ClassDiagram()
        {
}
        public void Write(string s)
        {
            this.bodi = s;

}
}
}