using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Exceptions
{
    internal class BaseException : Exception
    {
        public BaseException(string Message) : base(Message)
        {

        }
    }
}
