namespace SharedKernel.Exceptions.Device
{
    public class BaseHardwareException : BaseException
    {
        public string DeviceType { get; private set; }
        protected BaseHardwareException(string msg, string deviceType) : base(msg)
        {
            DeviceType = deviceType;
        }
    }
}
