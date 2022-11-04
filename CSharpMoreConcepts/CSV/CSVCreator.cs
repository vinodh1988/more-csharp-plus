using CSharpMoreConcepts.Data;
using CSharpMoreConcepts.Entities;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CSharpMoreConcepts.CSV
{
    internal class CSVCreator
    {
        static void Main(string[] s) {
            List<Student> list=StudentData.list;
            using (var writer = new StreamWriter("D:\\myfiles\\student.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture)) { 
               csv.WriteRecords(list);
            }
        }
    }
}
