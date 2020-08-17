using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence;
using Persistence.folderManager;
namespace core.diagrams.diagramCreators
{
     public class ExcelCreationStrategui : IdiagramCreationStrategi
    {
        public Diagram CreateDiagram(string path, string name)
        {
            throw new common.UnSuportedOperationException();
        }
        public Diagram CreateDiagram(string path)
        {
            UtilitiManager utiliti = UtilitiManager.GetInstance();
            ExcelDataRepresentation excel = new ExcelDataRepresentation();
            excel.name = utiliti.fm.GetFileName(path);
            excel.path = path;
            return excel;
             }
        }
}
