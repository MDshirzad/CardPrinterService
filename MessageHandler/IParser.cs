using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler
{
    internal interface IParser
    {
        object Parse(string input);
    }
}
