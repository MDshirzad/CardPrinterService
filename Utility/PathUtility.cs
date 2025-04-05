using Utility.Contracts;

namespace Utility
{
    internal class PathUtility : IPathUtility
    {
        const string KFrontFileBmp_Path = "k.bmp";
        const string KRearFileBmp_Path = "kB.bmp";
        const string LaserFrontFile_Path = "l.png";
        const string LaserRearFile_Path = "lb.png";

        const string OFile_Path = "o.bmp";
        const string FrontColoredFile_Path = "frontColored.bmp";
        const string BackColoredFile_Path = "backColored.bmp";
        const string ImagesBasePrefixDirectory = "TempPrintingImages";
        public string GetOFileBMPPath()
        {
            return GetPath(AppContext.BaseDirectory, ImagesBasePrefixDirectory, OFile_Path);
        }
        public string GetYMCKOFrontFileBMPPath()
        {
            return GetPath(AppContext.BaseDirectory, ImagesBasePrefixDirectory, FrontColoredFile_Path);
        }
        public string GetYMCKORearFileBMPPath()
        {
            return GetPath(AppContext.BaseDirectory, ImagesBasePrefixDirectory, BackColoredFile_Path);
        }
        public string GetKFrontFileBMPPath()
        {

            return GetPath(AppContext.BaseDirectory, ImagesBasePrefixDirectory, KFrontFileBmp_Path);
        }
        public string GetKRearFileBMPPath()
        {

            return GetPath(AppContext.BaseDirectory, ImagesBasePrefixDirectory, KRearFileBmp_Path);
        }
        private string GetPath(params string[] paths)
        {
            string fullPath = Path.Combine(paths);
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath!)!);

            return Path.Combine(paths);
        }

        public string GetLaserFrontFilePath()
        {
            return GetPath(AppContext.BaseDirectory, ImagesBasePrefixDirectory, LaserFrontFile_Path);
        }

        public string GetLaserRearFilePath()
        {
            return GetPath(AppContext.BaseDirectory, ImagesBasePrefixDirectory, LaserRearFile_Path);
        }

        public string BaseImagePath()
        {
            return GetPath(AppContext.BaseDirectory, ImagesBasePrefixDirectory);
        }
    }
}
