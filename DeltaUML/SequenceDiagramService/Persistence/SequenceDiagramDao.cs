using SequenceDiagramService.Core;
using DeltaUMLSdk;
namespace SequenceDiagramService.Persistence
{
    public class SequenceDiagramDao: ISequenceDiagramDao
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
