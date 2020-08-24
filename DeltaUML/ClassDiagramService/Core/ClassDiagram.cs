using System;
using System.ComponentModel.Composition;
using DeltaUMLSdk;
namespace  ClassDiagramService.Core
{
    [Serializable]
     [Export]
     
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