using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMoreConcepts.Exceptions
{
    internal class FarBeyond
    {
        static void Main(string[] n) {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(unchecked(int.MaxValue+1));
            try
            {
                Console.WriteLine("Enter an integer");
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter another Integer");
                int b = Int32.Parse(Console.ReadLine());
                int c = checked(a + b);
                Console.WriteLine("C=a+b and the value is" + c);
            }
            catch (OverflowException e) {
                Console.WriteLine("Gone Beyond Integer limit");
            }
            catch (FormatException)
            {
                Console.WriteLine("Give the value in number format");
            }
        }
    }
}
