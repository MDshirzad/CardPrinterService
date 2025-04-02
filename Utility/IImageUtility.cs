using CSharpFunctionalExtensions;
using SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public interface IImageUtility
    {

        public Result StoreImage(string base64, Enums.RibbonType type);
    }
}
