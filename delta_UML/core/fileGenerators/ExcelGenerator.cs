using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel=Microsoft.Office.Interop.Excel;
namespace core.fileGenerators
{
    public class ExcelGenerator
    {
        public void GenerateExcel(IList<string> header, string path)
        {
            excel.Workbook wb = default(excel.Workbook);
            excel.Worksheet ws = default(excel.Worksheet);
            wb.Worksheets.Add(ws);
            ws.Cells.CreateNames(header);
            wb.SaveAs(path);
}
    }

}