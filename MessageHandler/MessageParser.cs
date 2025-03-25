using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler
{
    internal class MessageParser : IMessageParser
    {
        public object ParseMessage(string message)
        {
            return "Success";
        }
    }
}
