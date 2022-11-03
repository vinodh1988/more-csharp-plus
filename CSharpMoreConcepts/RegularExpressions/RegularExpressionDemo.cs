using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpMoreConcepts.RegularExpressions
{
    internal class RegularExpressionDemo
    {
        static void Main(string[] n)
        {
            String[] strings = {
          "john",
          "jhon",
          "Jhon",
          "John",
          "Aravind",
          "234334",
          "34342",
          "123",
          "Ashok",
          "Star war",
          "War",
          "Turf",
          "Granite",
          "Road",
          "Arun123",
          "Kenny34",
          "Christopher",
          "jug",
          "mug",
          "dog",
           "Krishna",
          "harry234@gmail.com",
          "john@yahoo.com" ,
          "giri@gmail.com",
          "jose.124@yahoo.in",
          "naveen_india@hotmail.com",
          "vinay_19324@gmail.com",
          "sameul@123",
          "peter_123@yahoo",
          "jackson1jack",
           "in",
           "so"
        };
            String expression1 = @"^K";
            String expression2 = @"n$";
            string expression3 = @"^[0-9]";
            string expression4 = @"[0-9]";
            string expression5 = @"[0-9]{4}";
            string expression6 = @"^...$";
            string expression7 = @"^[a-z][a-z][a-z]$";
            string expression8 = @"^.[aeu]";
            string expression9 = @"^[a-z][a-z]+[a-z]$";
            string expression10 = @"^[a-z][a-z]*[a-z]$";
            string expression11 = @"^[a-z][a-z0-9\._]+@[a-z]{3,15}[\.](com|net|in)$";
            Regex regex = new Regex(expression11);
            foreach (var x in strings)
            {
                if (regex.Match(x).Success)
                {
                    Console.WriteLine(x);
                }

            }
            
        }
    }
}
//
/*
 *  $ - ending with
 *  ^ - starting with
 *  [0-9] - any digit from to 0 to 9  - one occurance
 *  {n} - n occurances
 *  . - any Character
 *  [a-z]  - a to z  - one occurance
 *  [xyz] = x or y or z
 *  + - one or more occurances
 *  * - zero or more occurances
 *  (in|sin|pin) - in or pin or sin
 */