using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler
{
    public interface IMessageParser
    {
        public object ParseMessage(string message);
    }
}
