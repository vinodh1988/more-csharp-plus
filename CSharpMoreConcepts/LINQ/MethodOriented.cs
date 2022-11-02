using CSharpMoreConcepts.Data;
using CSharpMoreConcepts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpMoreConcepts.LINQ
{
    internal class MethodOriented
    {
        static void Main(string[] n) {
            var studentdata = StudentData.list;
            var result = studentdata.Where(x => x.Percentage > 80).OrderByDescending(x=>x.Percentage);

            foreach (var x in result)
                Console.WriteLine(x);

            var avg = studentdata.Average(x=>x.Percentage);

            Console.WriteLine("Average of all the students : {0}", avg);

            var cities = studentdata.GroupBy(s => s.City);

            foreach (var x in cities) {
                Console.WriteLine(" {0} -> Average : {1}", x.Key, x.Average(s => s.Percentage));
            }
        }
    }
}
