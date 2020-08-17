using core.common;
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
switch(extension)
            {
                case ".cd":
                    {
                        return new ClassDiagramCreationStrategi();
                    }
                case ".sd":
                    {
                        return new SequenceDiagramCreationStrategi();
}
                case ".xlsx":
                    {
                        return new ExcelCreationStrategui();
                    }
default:
                    {
throw new UnSuportedOperationException();
}
}
}
}
}
