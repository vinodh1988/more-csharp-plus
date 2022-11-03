using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpMoreConcepts.FileHandling
{
    internal class FileReaderDemo
    {
        static void Main(String[] n) {
            StreamReader sr = new StreamReader("d:\\myfiles\\sample.txt");
            String str = null;
            while ((str=sr.ReadLine())!=null) { 
               Console.WriteLine(str);
            }
            sr.Close();
        }
    }
}
