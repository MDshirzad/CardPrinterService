namespace SharedKernel.Exceptions.Device
{
    public class PrinterException : BaseHardwareException
    {
        public PrinterException(string msg) : base(msg, "Printer")
        {

        }
    }
}
