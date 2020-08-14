using core.diagrams.sequenceDiagram;
namespace core.dao
{
    public interface ISequenceDiagramDao
    {
        SequenceDiagram ReadDiagram(string path);
        void WriteDiagram(SequenceDiagram sd);
    }
}
