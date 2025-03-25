using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware.Printer.Evolis.Contracts
{
    public interface IPrintKO
    {
        void Print_SingleSide_KO();
        void Print_DoubleSide_KO();
    }
}
