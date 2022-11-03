using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpMoreConcepts.Exceptions
{
    internal class ExceptionDemo
    {
        static void Main(string[] n) {
            int[] existingIds = { 343, 43, 435, 35, 346, 32, 22, 2, 25, 2 };
            try
            {
                Console.WriteLine("Enter an integer");
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter another Integer");
                int b = Int32.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("a/b= {0}", a / b);
                Console.WriteLine("Enter a number for the id");
                int id = Int32.Parse(Console.ReadLine());
                if (existingIds.Contains(id))
                    throw new RecordAlreadyExistsException();
                else
                    Console.WriteLine("Creating a new Record with id" + id);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator should not be zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("The value Which you entered is not in numberic format");
            }
            catch (RecordAlreadyExistsException e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace + " " + e.GetType());
            }
            finally
            {

                Console.WriteLine("Code Always Runs");
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
