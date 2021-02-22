using SequenceDiagramService.Core;
using SequenceDiagramService.Persistence;
using DeltaUMLSdk;
using System;

namespace SequenceDiagramService.Core
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
