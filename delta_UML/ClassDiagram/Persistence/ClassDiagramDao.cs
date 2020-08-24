using core.dao;
using core.diagrams;
namespace ClassDiagramComponents.Persistence

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
