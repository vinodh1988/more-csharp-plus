using CSharpMoreConcepts.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpMoreConcepts.FileHandling
{
    internal class WriteStudent
    {
        static void Main(string[] n) {
            StreamWriter sw = new StreamWriter("D:\\myfiles\\studentdata.txt");
            while (true)
            {
                Console.WriteLine("Enter Sno:");
                int sno=Int32.Parse(Console.ReadLine());
                if (sno <= 0)
                    break;
                Console.WriteLine("Enter Name:");
                String name = Console.ReadLine();
                Console.WriteLine("Enter City:");
                String city = Console.ReadLine();
               /* Student student = new Student()
                {
                    Sno = sno,
                    Name = name,
                    City =city
                };*/
                String data = String.Format("{0,10}{1,20}{2,20}",sno,name,city);
                sw.WriteLine(data);
               
            }
            sw.Flush();
            sw.Close();
        }
    }
}
