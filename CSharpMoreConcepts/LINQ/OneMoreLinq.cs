using CSharpMoreConcepts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpMoreConcepts.LINQ
{
    internal class OneMoreLinq
    {
        static void Main(string[] n) {
            List<Student> list = new List<Student>()
            {
                new Student(){ Sno=1, Name="Joseph", City="Chennai", Percentage=80.9f},
                new Student(){ Sno=2, Name="Nancy", City="Mumbai", Percentage=40.2f},
                new Student(){ Sno=3, Name="Roger", City="Chennai", Percentage=60.3f},
                new Student(){ Sno=4, Name="Zaheer", City="Bangalore", Percentage=89.4f},
                new Student(){ Sno=5, Name="Pradeep", City="Hyderabad", Percentage=34.53f},
                new Student(){ Sno=6, Name="Lokesh", City="Mumbai", Percentage=90.3f},
                new Student(){ Sno=7, Name="Rakesh", City="Jaipur", Percentage=94.43f},
                new Student(){ Sno=8, Name="Naresh", City="Delhi", Percentage=56.34f}
            };

            var result = from s in list
                         where s.Percentage >= 90
                         select s;

            foreach(var x in result)
                Console.WriteLine("Name is {0}, City is {1} ", x.Name,x.City);
        }
    }
}
