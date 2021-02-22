using Microsoft.Office.Interop.Excel;
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
            excel.Application ap = new excel.Application();
            Workbook book=ap.Workbooks.Add();
            Worksheet sheet = book.Worksheets.Add();
            int columnCount = 1;
            foreach(string i in header)
{
                sheet.Cells[1, columnCount] = i;
                columnCount++; 
            }
            book.SaveAs(path);
            book.Close();
            ap.Quit();
        }

    }
}