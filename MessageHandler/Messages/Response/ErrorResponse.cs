namespace MessageHandler.Messages.Response
{
    internal class ErrorResponse : BaseResponse
    {
        public string? errorMessage { get; private set; }
        public ErrorResponse(string Error, string informative = "")
        {
            isSuccessfull = false;
            errorMessage = Error;
            informativeMessage = informative;
        }
    }
}
