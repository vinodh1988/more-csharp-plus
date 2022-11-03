using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMoreConcepts.Exceptions
{
    internal class ExceptionDemo
    {
        static void Main(string[] n) {
            try
            {
                Console.WriteLine("Enter an integer");
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter another Integer");
                int b = Int32.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("a/b= {0}", a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator should not be zero");
            }
            catch (FormatException) {
                Console.WriteLine("The value Which you entered is not in numberic format");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace + " " + e.GetType());
            }
        }
        /*
         * Exception - Runtime issue
         * in C# each Exception is represented by an Exception class
         * All Exception classes subclass of Exception
         * Exception if not handled will lead abrupt termination of running code
         * Exception if excepted need to ba handled by using exception handling keywords
         * 
         *    try
         *    throw
         *    catch
         *    finally*/
    }
}
