using core.diagrams;
namespace core.dao
{
    public interface IClassDiagramDao
    {
        ClassDiagram ReadDiagram(string path);
        void WriteDiagram(ClassDiagram cd);

    }
}
