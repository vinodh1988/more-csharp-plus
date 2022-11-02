using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace CSharpMoreConcepts.LINQ
{
    internal class SimpleLinq
    {
        static void Main(String[] n)
        {
            string[] name = { "Roger", "James", "Harris", "Harsh", "Isaac", "Johnson", "Marsh" };

            var result = from x in name
                         where x.StartsWith("H")
                         select x;

            foreach (var p in result)
                Console.WriteLine(p);
        }

        /*
         * LINQ - language independent query
         * 
         * Two approaches
         *    1. LINQ Query Syntax
         *    2. LINQ Method Syntax
         *    
         *    Query Syntax:
         *    
         *       from <variable> in <IEnumerable> or IQueryable<T> 
         *       <Query Operator> expression
         *       select result
         */
    }
}
