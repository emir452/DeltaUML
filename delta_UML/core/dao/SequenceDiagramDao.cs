using core.diagrams.sequenceDiagram;
namespace core.dao
{
    public class SequenceDiagramDao : ISequenceDiagramDao
    {
        public SequenceDiagram ReadDiagram(string path)
        {
            return new DiagramDao().ReadDiagram<SequenceDiagram>(path);
        }
        public void WriteDiagram(SequenceDiagram sd)
        {
            new DiagramDao().WriteDiagram<SequenceDiagram>(sd, sd.path);
        }
    }

}
