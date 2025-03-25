using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware.Printer.Evolis.Contracts
{
    public interface IEvolisPrinter : IRibbonPrinter, IMagnWriter
    {

        public void ExecutePrinterCommand(string command);
    }
}
