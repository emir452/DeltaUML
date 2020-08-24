using Persistence;
using ClassDiagramComponents.Persistence;
using core.diagrams;
using core.diagrams.diagramCreators;
using System;
namespace ClassDiagramComponents.Core

{
    public class ClassDiagramCreationStrategi : IdiagramCreationStrategi
    {
        private UtilitiManager fileSistem;
        private core.dao.IClassDiagramDao diagramDao;
        public ClassDiagramCreationStrategi()
        {
            fileSistem = UtilitiManager.GetInstance();
            diagramDao = new ClassDiagramDao();
        }
        public Diagram CreateDiagram(string path)
        {
            return diagramDao.ReadDiagram(path);
        }
        public Diagram CreateDiagram(String path, string name)
        {
            string pathDiagram = fileSistem.ConbinePaths(path, name) + ".cd";
            ClassDiagram cd = new ClassDiagram();
            cd.name = name;
            cd.path = pathDiagram;
            cd.bodi = "";
            diagramDao.WriteDiagram(cd);
            return cd;

        }
    }
}
