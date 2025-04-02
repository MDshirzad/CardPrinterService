using System.Runtime.InteropServices;

namespace Hardware.Roller.F1
{
    internal class F1ApiWrapper
    {


        // Define the ISSUERHANDLE type as ULONG_PTR
        public delegate nint ISSUERHANDLE();

        // Import the necessary functions from F1API.dll
        [DllImport("F1API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int F1_Connect(uint dwPortNumber, uint dwBaudRate, byte bAddress, out nint phIssuer);

        [DllImport("F1API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int F1_Disconnect(nint hIssuer);

        [DllImport("F1API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int F1_Reset(nint hIssuer);



        [DllImport("F1API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int F1_GetStatus(nint hIssuer, out uint pdwStatusFlags);

        [DllImport("F1API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int F1_Dispense(nint hIssuer, byte bMode);

        [DllImport("F1API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int F1_Capture(nint hIssuer);
    }
}
