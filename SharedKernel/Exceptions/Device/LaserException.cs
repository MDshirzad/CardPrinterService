namespace SharedKernel.Exceptions.Device
{
    public class LaserException : BaseHardwareException
    {
        public LaserException(string msg) : base(msg, "Laser")
        {

        }
    }
}
