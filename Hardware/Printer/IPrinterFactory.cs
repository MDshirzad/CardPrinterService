 
using Hardware.Printer.Evolis.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hardware.Constatns;

namespace Hardware.Printer
{
    public interface IPrinterFactory
    {
        IEvolisPrinter Create(PrinterCommunicationType type);
 
    }
}
