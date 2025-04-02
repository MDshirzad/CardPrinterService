namespace SharedKernel.Exceptions.MessageHandlers
{
    public class UnHandledException : BaseException
    {
        const string UnhandledMessage = "UnhandledException";
        public UnHandledException(string message = UnhandledMessage) : base(message)
        {

        }
    }
}
