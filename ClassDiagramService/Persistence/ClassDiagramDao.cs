using DeltaUMLSdk;
using ClassDiagramService.Core;
namespace ClassDiagramService.Persistence

{
    public class ClassDiagramDao : IClassDiagramDao
    {
        public void WriteDiagram(ClassDiagram cd)
        {
            new DiagramDao().WriteDiagram<ClassDiagram>(cd, cd.path);

        }
        public ClassDiagram ReadDiagram(string path)
        {
            return new DiagramDao().ReadDiagram<ClassDiagram>(path);
        }
    }
}
