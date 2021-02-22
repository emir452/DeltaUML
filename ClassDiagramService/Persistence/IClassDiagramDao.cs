using ClassDiagramService.Core;
namespace ClassDiagramService.Persistence
{
    public interface IClassDiagramDao
    {
        ClassDiagram ReadDiagram(string path);
        void WriteDiagram(ClassDiagram cd);

    }
}
