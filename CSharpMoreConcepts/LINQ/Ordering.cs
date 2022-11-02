using CSharpMoreConcepts.Data;
using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CSharpMoreConcepts.LINQ
{
    internal class Ordering
    {
        static void Main(string[] n) { 
          var orderedStudents = from s in StudentData.list
                                orderby s.Percentage descending
                                select s;

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }

            var students = from s in StudentData.list
                           where s.Name.Length > 5 && s.Percentage > 60
                           select new {LuckyNumber= new Random().Next(), Name = s.Name.ToUpper()+" is a good human being"};

            Console.WriteLine("========================================");
            foreach (var student in students) {
              Console.WriteLine(student);
            }

            
        }
    }
}
