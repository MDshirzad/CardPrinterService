namespace MessageHandler.Messages.Exceptions
{
    internal class UnHandledException : BaseException
    {
        const string UnhandledMessage = "UnhandledException";
        public UnHandledException(string message = UnhandledMessage) : base(message)
        {

        }
    }
}
