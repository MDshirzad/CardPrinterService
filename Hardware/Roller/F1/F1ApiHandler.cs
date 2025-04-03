using Logging;
using SharedKernel.Exceptions.Device;
using static Hardware.Roller.RollerConstants;
using static Hardware.Roller.F1.F1ApiWrapper;
using static Hardware.Roller.F1.F1Constants;
using CSharpFunctionalExtensions;
namespace Hardware.Roller.F1
{
    internal class F1ApiHandler : IRollerHandler
    {
        private IntPtr _issuerHandle;
        public F1ApiHandler()
        {
            Connect(1);
        }
        public Result Capture()
        {
            var res = F1_Capture(_issuerHandle);
            if (res == 0)
                return Result.Success();
            return Result.Failure(res.ToString());
        }

        public Result Eject()
        {
            var res = F1_Dispense(_issuerHandle, DISP_EJECT_TO_FRONT);
            if (res == 0)
                return Result.Success();
            return Result.Failure(res.ToString());
        }

        public CardStatus GetStatus()
        {
            uint StatusFlag = default;
            F1_GetStatus(_issuerHandle, out StatusFlag);
            LogWriter.WriteHardwareInfo("Roller Status Got with code:" + StatusFlag);
            return (CardStatus)StatusFlag;
        }

        void Connect(uint PortNumber)
        {
            int result = 100;

            for (int i = 0; i <= 15; i++)
            {
                var herxStromg = i.ToString("X");
                result = F1ApiWrapper.F1_Connect(PortNumber,
                    9600,
                    (byte)int.Parse(herxStromg, System.Globalization.NumberStyles.HexNumber)
                    , out _issuerHandle);
                if (result == F1_S_SUCCESS)
                    break;
            }

            LogWriter.WriteHardwareInfo("Rolle is Connected?: " + result.ToString());
            if (result != F1_S_SUCCESS)
            {
                throw new RollerException("Error On Connect To Roller");

            }

        }
    }
}
