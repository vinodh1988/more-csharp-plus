using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpMoreConcepts.FileHandling
{
    internal class DirectoryDemo
    {
        static void Main(string[] n) {
            DirectoryInfo dir = new DirectoryInfo("d:\\myfiles");
            DirectoryInfo dir2 = new DirectoryInfo("d:\\copiedfolder");
            dir2.Create();
            IEnumerable<FileInfo> i=dir.EnumerateFiles();
            foreach (var x in i) {
                Console.WriteLine("Fullname: {0}", x.FullName);
                Console.WriteLine("Name:{0}",x.Name);
                Console.WriteLine("Length: {0}", x.Length);
                Console.WriteLine("CreationTime: {0}", x.CreationTime);
                File.Copy(x.FullName, dir2.FullName+"\\"+x.Name, true);
                Console.WriteLine("=========================================================================");
            }
        }
    }
}
