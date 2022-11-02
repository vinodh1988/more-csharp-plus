using CSharpMoreConcepts.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpMoreConcepts.LINQ
{
    internal class Aggregation
    {
        static void Main(string[] n) {
            var result = from x in StudentData.list
                         group x by x.City into g
                         select new { AverageMarks = g.Average(x => x.Percentage) ,City = g.Key };

            foreach (var x in result) { 
               Console.WriteLine(x);
            }
        }
    }
}
