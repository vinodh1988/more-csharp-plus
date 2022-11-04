using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpMoreConcepts.FileHandling
{
    internal class FileWrite
    {
        static void Main(string[] n) {
            StreamWriter stream = new StreamWriter("D:\\myfiles\\sample.txt");
            using (stream)
            {
                string sample = "";
                while (!sample.Equals("End"))
                {
                    sample = Console.ReadLine();
                    stream.WriteLine(sample);
                }
            }
           // stream.Flush();
            //stream.Close();
        }
    }
}
