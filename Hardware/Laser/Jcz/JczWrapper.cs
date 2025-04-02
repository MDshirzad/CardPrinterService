using System.Runtime.InteropServices;
using System.Text;

namespace Hardware.Laser.Jcz
{
    internal class JczWrapper
    {
        [DllImport("MarkEzd", EntryPoint = "lmc1_Initial2", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Initialize(string PathName, bool bTestMode);

        [DllImport("MarkEzd", EntryPoint = "lmc1_SetBitmapEntParam2", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SetBitmapEntParam2(string strEntName,
                                                              string strImageFileName,
                                                              int nBmpAttrib,
                                                              int nScanAttrib,
                                                              double dBrightness,
                                                              double dContrast,
                                                              double dPointTime,
                                                              int nImportDpi,
                                                              bool bDisableMarkLowGrayPt,
                                                              int nMinLowGrayPt
                                                               );

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_GetBitmapEntParam2", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetBitmapEntParam2(string strEntName,
                                                      StringBuilder strImageFileName,
                                                      ref int nBmpAttrib,
                                                      ref int nScanAttrib,
                                                      ref double dBrightness,
                                                      ref double dContrast,
                                                      ref double dPointTime,
                                                      ref int nImportDpi,
                                                      ref int bDisableMarkLowGrayPt,
                                                      ref int nMinLowGrayPt
                                                      );
        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_SaveEntLibToFile", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SaveEntLibToFile(string strFileName);
        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_Mark", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Mark(bool Fly);

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_AddFileToLib", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddFileToLib(string FileName, string pEntName, double dPosX, double dPosY, double dPosZ, int nAlign, double dRatio, int nPenNo, bool bHatchFile);

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_ClearEntLib", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lmc1_ClearEntLib();

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_RotateEnt", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lmc1_RotateEnt(string fileName, double xCenter, double yCenter, double angle);

        [DllImport("MarkEzd.dll", EntryPoint = "lmc1_RedLightMark", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int lmc1_RedLightMark();
    }
}
