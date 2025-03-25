using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware.Printer.Evolis.Contracts
{
    public interface IMagnWriter
    {
        void WriteMagn(string Track1, string Track2, string Track3);
    }
}
