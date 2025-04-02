using CSharpFunctionalExtensions;

namespace Hardware.Laser
{
    public interface ILaserHandler
    {
        public Result Engrave(string ImagePath, double x, double y);


    }
}
