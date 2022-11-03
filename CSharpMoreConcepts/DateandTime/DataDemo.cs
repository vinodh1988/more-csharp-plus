using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CSharpMoreConcepts.DateandTime
{
    internal class DateDemo
    {
        static void Main(string[] s) {
            DateTime d = DateTime.Today;
            Console.WriteLine(d);
            d = DateTime.Now;
            Console.WriteLine("Now:{0}", d);
            Console.WriteLine(d.DayOfWeek);
            Console.WriteLine(d.Date);
            Console.WriteLine(d.DayOfYear);
            Console.WriteLine(d.TimeOfDay);
            Console.WriteLine(d.AddDays(5));
            Console.WriteLine(d.ToString("MMMM, dd yyyy"));
             d = new DateTime(2022, 6, 12);
            Console.WriteLine(d);
        }
    }
}
