using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Application.Exceptions
{
    public class MyException : Exception
    {
        public MyException() : base("Error Occured")
        {

        }

        public MyException(string message) : base(message)
        {

        }

        public MyException(Exception exception) : this(exception.Message)
        {

        }
    }
}
