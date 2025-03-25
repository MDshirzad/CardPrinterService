using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware.Printer.Evolis.Contracts
{
    public interface IPrintK
    {
        void Print_SingleSide_K();
        void Print_DoubleSide_K();
    }
}
