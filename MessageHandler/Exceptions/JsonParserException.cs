using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Exceptions
{
    internal class JsonParserException : BaseException
    {
        const string JsonException = "Invalid Json Object Detected";
        internal JsonParserException(string message= JsonException) : base(message)
        {

        }
    }
}
