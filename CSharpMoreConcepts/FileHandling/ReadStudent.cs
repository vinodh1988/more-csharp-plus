using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpMoreConcepts.FileHandling
{
    internal class ReadStudent
    {
        static void Main(String[] n) {
            try
            {
                StreamReader str = new StreamReader("d:\\myfiles\\studentdata.txt");
                string x = null;
                while ((x = str.ReadLine()) != null)
                {
                    string[] array = x.Split(" ");
                    foreach (var p in array)
                        if(!p.Equals(""))
                        Console.WriteLine(p);
                }
            }
            catch (FileNotFoundException e) {
                Console.WriteLine("File not exists");
            }
        }
    }
}
