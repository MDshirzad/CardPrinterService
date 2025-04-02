using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Contracts
{
    public interface IPathUtility
    {
        string GetOFileBMPPath();
        string GetYMCKOFrontFileBMPPath();
        string GetKFrontFileBMPPath();
        string GetKRearFileBMPPath();
        string GetYMCKORearFileBMPPath();
    }
}
