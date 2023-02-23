using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryExample
{

    public class MyCustomException : Exception
    {

        public MyCustomException() { }
        public MyCustomException(string message) : base(message) { }
        public MyCustomException(string message, Exception inner) : base(message, inner) { }

    }
}
