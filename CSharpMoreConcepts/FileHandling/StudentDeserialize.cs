using CSharpMoreConcepts.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CSharpMoreConcepts.FileHandling
{
    internal class StudentDeserialize
    {
        static void Main(string[] n) {
            Stream stream = new FileStream("d:\\myfiles\\student", FileMode.Open, FileAccess.Read);
            IFormatter formatter = new BinaryFormatter();
            try
            {
                while (true) {
                 
                     Student   st = (Student)formatter.Deserialize(stream);
                   
                    Console.WriteLine("{0,10}{1,20}{2,20}", st.Sno, st.Name, st.City);
                }

            }
            catch (SerializationException)
            {
                Console.WriteLine("               ######### END ################");
            }
        }
    }
}
