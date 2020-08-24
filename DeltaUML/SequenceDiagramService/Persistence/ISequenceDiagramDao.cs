using SequenceDiagramService.Core;
 namespace SequenceDiagramService.Persistence
{
    public interface ISequenceDiagramDao
    {
        SequenceDiagram ReadDiagram(string path);
        void WriteDiagram(SequenceDiagram sd);
    }
}
