using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware.Roller.F1
{
    public class F1Constants
    {
        public const int F1_S_SUCCESS = 0;
        public const int F1_E_DEVICE_UNRECOGNIZED = 0x300;
        public const int F1_E_PORT_UNAVAILABLE = 0x303;
        public const int F1_E_UNKNOWN_ERROR = 0x311;
        public const int F1_E_INTERNAL_ERROR = 0x312;
        public const int F1_E_COMM_TIMEOUT = 0x320;
        public const int F1_E_INVALID_HANDLE = 0x330;
        public const int F1_E_INVALID_PARAMETER = 0x331;
        public const int F1_E_NO_MEMORY = 0x332;
        public const int F1_E_BUFFER_TOO_SMALL = 0x334;

        // Define other constants
        public const int DISP_EJECT_TO_FRONT = 0x30;
        public const int DISP_RETURN_TO_FRONT = 0x34;
        public const int DISP_RETURN_TO_READ_POS = 0x36;
        public const int EM_PROHIBITED = 0x30;
        public const int EM_CAPTURE_TO_BOX = 0x31;
        public const int EM_DOCKED_TO_READ_POS = 0x32;
    }
}
