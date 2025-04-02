using CSharpFunctionalExtensions;
using Logging;

using SharedKernel.Exceptions.Device;

using System.Text;


namespace Hardware.Laser.Jcz
{
    internal class JczLaserHandler : ILaserHandler
    {
        const string InternalLaserEntityName = "DbLaserObjectName";
        public JczLaserHandler()
        {
            var result = JczWrapper.Initialize(Directory.GetCurrentDirectory(), false);
            if (result != 0)
                throw new LaserException("Error On Initialize Laser Code:" + result);
        }
        public Result Engrave(string ImagePath, double x, double y)
        {
            JczWrapper.lmc1_ClearEntLib();
            JczWrapper.AddFileToLib(ImagePath, InternalLaserEntityName, x, y, 0, 0, 1, 1, false);
            var resultr = JczWrapper.lmc1_RotateEnt(InternalLaserEntityName, 0, 0, 180);
            SetBitmapParam(InternalLaserEntityName);
            LogWriter.WriteHardwareInfo("+++Starting Mark+++");
            var markresult = JczWrapper.Mark(false);
            LogWriter.WriteHardwareInfo("---End Mark---");
            var resClear = JczWrapper.lmc1_ClearEntLib();
            LogWriter.WriteHardwareInfo("Clear Lib Result :" + resClear);
            if (markresult != 0)
                Result.Failure("ErrorCode:" + markresult);
            return Result.Success();
        }


        void SetBitmapParam(string EntName)
        {
            string entName = EntName;
            StringBuilder bmpPath = new StringBuilder(255);
            int bmpAttrib = 0;
            int scanAttrib = 0;
            double bright = 0;
            double contrast = 0;
            double pointTime = 0;
            int importDpi = 0;
            int disableMarkLowGrayPt = -1;
            int minLowGrayPt = -1;
            int err = JczWrapper.GetBitmapEntParam2(entName, bmpPath, ref bmpAttrib, ref scanAttrib, ref bright, ref contrast,
               ref pointTime, ref importDpi, ref disableMarkLowGrayPt, ref minLowGrayPt);
            if (err == 0)
            {
                var invert = ((scanAttrib & 0x0001) == 0x0001) ? true : false;
                var gray = ((scanAttrib & 0x0002) == 0x0002) ? true : false;
                var lightcheck = ((scanAttrib & 0x0004) == 0x0004) ? true : false;
                var dither = ((scanAttrib & 0x0010) == 0x0010) ? true : false;
                var eachRowPointOff = ((scanAttrib & 0x0100) == 0x0100) ? true : false;
                var bidir = ((scanAttrib & 0x1000) == 0x1000) ? true : false;
                var ydir = ((scanAttrib & 0x2000) == 0x2000) ? true : false;
                var dril = ((scanAttrib & 0x4000) == 0x4000) ? true : false;
                var power = ((scanAttrib & 0x8000) == 0x8000) ? true : false;

                var dynfile = ((bmpAttrib & 0x1000) == 0x1000) ? true : false;
                var fixedwidth = ((bmpAttrib & 0x2000) == 0x2000) ? true : false;
                var dixHeight = ((bmpAttrib & 0x4000) == 0x4000) ? true : false;
                var fixDpi = ((bmpAttrib & 0x8000) == 0x8000) ? true : false;

                var DisableMarkLowGrayPt = disableMarkLowGrayPt == 1 ? true : false;
                var path = bmpPath.ToString();

                double PointTime = 0.3;
                int bmpAttrib2 = 0;
                int scanAttrib2 = 0;
                if (invert) scanAttrib2 += 0x0001;
                if (gray) scanAttrib2 += 0x0002;
                if (lightcheck) scanAttrib2 += 0x0004;
                if (dither) scanAttrib2 += 0x0010;
                if (eachRowPointOff) scanAttrib2 += 0x0100;
                if (bidir) scanAttrib2 += 0x1000;
                if (ydir) scanAttrib2 += 0x2000;
                if (dril) scanAttrib2 += 0x4000;
                if (power) scanAttrib2 += 0x8000;

                if (dynfile) bmpAttrib2 += 0x1000;
                if (fixedwidth) bmpAttrib2 += 0x2000;
                if (dixHeight) bmpAttrib2 += 0x4000;
                if (fixDpi) bmpAttrib2 += 0x8000;

                int err2 = JczWrapper.SetBitmapEntParam2(EntName, path, bmpAttrib2, scanAttrib2, bright, contrast,
                     PointTime, importDpi, DisableMarkLowGrayPt, minLowGrayPt);
            }
        }
    }
}
