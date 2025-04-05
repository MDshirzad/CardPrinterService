namespace Utility.Contracts
{
    public interface IPathUtility
    {
        string BaseImagePath();
        string GetOFileBMPPath();
        string GetYMCKOFrontFileBMPPath();
        string GetKFrontFileBMPPath();
        string GetKRearFileBMPPath();
        string GetYMCKORearFileBMPPath();
        string GetLaserFrontFilePath();
        string GetLaserRearFilePath();
    }
}
