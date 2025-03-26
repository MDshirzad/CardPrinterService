using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Exceptions
{
    internal class UnHandledException:BaseException
    {
        const string UnhandledMessage = "UnhandledException";
        public UnHandledException(string message= UnhandledMessage) :base(message)
        {
            
        }
    }
}
