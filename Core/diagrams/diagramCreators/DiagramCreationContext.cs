using core.common;
using DeltaUMLSdk;
using Persistence;
using System;
using System.IO;
namespace core.diagrams.diagramCreators

{
    public class DiagramCreationContext
    {
        public Diagram CreateDiagram(String path)
        {
            return this.SelectStrategi(path).CreateDiagram(path);
        }
        public IdiagramCreationStrategi SelectStrategi(string path)
        {
            string extension = UtilitiManager.GetInstance().fm.GetFileExtension(path);
            return null;
}
}
}
