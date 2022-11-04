using CSharpMoreConcepts.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CSharpMoreConcepts.FileHandling
{
    internal class StudentSerialization
    {
        static void Main(string[] n) {
            Stream stream = new FileStream("d:\\myfiles\\student",FileMode.OpenOrCreate,FileAccess.Write);
            IFormatter formatter = new BinaryFormatter();

            while (true)
            {
                Console.WriteLine("Enter Sno:");
                int sno = Int32.Parse(Console.ReadLine());
                if (sno <= 0)
                    break;
                Console.WriteLine("Enter Name:");
                String name = Console.ReadLine();
                Console.WriteLine("Enter City:");
                String city = Console.ReadLine();
                Student student = new Student()
                 {
                     Sno = sno,
                     Name = name,
                     City =city
                 };
                formatter.Serialize(stream, student);

            }
            stream.Flush();
            stream.Close();
        }
    }
}
