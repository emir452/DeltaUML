using core.dao;
using Persistence;
using System;
namespace core.diagrams.diagramCreators
{
    public class ClassDiagramCreationStrategi : IdiagramCreationStrategi
    {
        private UtilitiManager fileSistem;
        private IClassDiagramDao diagramDao;
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
