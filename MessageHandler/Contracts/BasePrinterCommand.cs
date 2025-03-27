using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Contracts
{
    internal abstract record BasePrinterCommand : BaseCommand{
        public string PrinterName { get; set; } =string.Empty;
    }
   
}
