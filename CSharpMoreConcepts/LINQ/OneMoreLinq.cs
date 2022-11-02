using CSharpMoreConcepts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CSharpMoreConcepts.Data;

namespace CSharpMoreConcepts.LINQ
{
    internal class OneMoreLinq
    {
        static void Main(string[] n) {
        

            var result = from s in StudentData.list
                         where s.Percentage >= 90
                         select new { Name = s.Name, City =s.City};

            foreach(var x in result)
                Console.WriteLine("Name is {0}, City is {1} ", x.Name,x.City);
        }
    }
}
