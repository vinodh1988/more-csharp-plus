using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMoreConcepts.Entities
{
    [Serializable]
    internal class Student
    {
        public int Sno { get; set; }
        public String Name { get; set; }
        
        public String City { get; set; }

        public Single Percentage { get; set; }


        public override string ToString() {
            return new { Sno = Sno, Name = Name, City = City, Percentage = Percentage }.ToString();
          }
        }

    }

