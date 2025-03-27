namespace MessageHandler.Response
{
    internal class BaseResponse
    {
        public bool isSuccessfull { get; protected set; }

        public string? informativeMessage { get; set; }

    }
}
