using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpMoreConcepts.Exceptions
{
    internal class RecordAlreadyExistsException: Exception
    {
       new public string Message = "Record already Exists";
        public override string ToString() {
            return Message+ " with that id";
        }
    }
}
