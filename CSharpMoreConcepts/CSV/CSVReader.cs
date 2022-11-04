using CSharpMoreConcepts.Entities;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace CSharpMoreConcepts.CSV
{
    internal class CSVReader
    {

        static void Main(string[] str) {
            using (var reader = new StreamReader("d:\\myfiles\\student.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Student>();
                foreach (var x in records)
                    Console.WriteLine(x);
            }
        }
    }
}
