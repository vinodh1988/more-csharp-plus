using CSharpMoreConcepts.Data;
using CSharpMoreConcepts.Entities;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpMoreConcepts.Excel
{
    internal class CreateExcel
    {
        static void Main(string[] n) {
            string path = "d:\\myfiles\\people.xslx";

           Application app = new Application();

            if (app == null)
            {
                Console.WriteLine("Excel is not in the current system");
                return;
            }
            object NoValue =  System.Reflection.Missing.Value;
            Workbook workbook = app.Workbooks.Add(NoValue);
            Worksheet sheet =(Worksheet) workbook.Worksheets.Item[1];

            List<Student> list = StudentData.list;

            sheet.Cells[1, 1] = "Sno";
            sheet.Cells[1, 2] = "Name";
            sheet.Cells[1, 3] = "City";
            sheet.Cells[1, 4] = "Percentage";
            int row = 2;
            foreach (var x in list) {
                sheet.Cells[row, 1] =  x.Sno;
                sheet.Cells[row, 2] = x.Name;
                sheet.Cells[row, 3] = x.City;
                sheet.Cells[row, 4] = x.Percentage;
                row++;
            }
            workbook.SaveAs(path, XlFileFormat.xlOpenXMLWorkbook, NoValue, NoValue,NoValue
                ,NoValue,XlSaveAsAccessMode.xlExclusive,NoValue,NoValue,NoValue,NoValue);
            workbook.Close();
            app.Quit();
            Marshal.ReleaseComObject(sheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(app);

        }
    }
}
