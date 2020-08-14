using core.common;
using core.dao;
using core.diagrams.sequenceDiagram;
using Persistence;
using System;

namespace core.diagrams.diagramCreators
{
    public class SequenceDiagramCreationStrategi : IdiagramCreationStrategi
    {
        public Diagram CreateDiagram(string path)
        {
            if (UtilitiManager.GetInstance().fm.GetFileExtension(path).Equals(".sd"))
            {
                return new SequenceDiagramDao().ReadDiagram(path);
            }
            else
            {
                throw new UnSuportedOperationException();
            }

        }
        public Diagram CreateDiagram(string path, String name)
        {
            SequenceDiagram sd = new SequenceDiagram();
            path = UtilitiManager.GetInstance().ConbinePaths(path, name);
            path += ".sd";
            sd.path = path;
            sd.name = name;
            new SequenceDiagramDao().WriteDiagram(sd);
            return sd;

        }
    }
}
