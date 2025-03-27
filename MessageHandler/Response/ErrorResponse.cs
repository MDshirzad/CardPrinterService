namespace MessageHandler.Response
{
    internal class ErrorResponse : BaseResponse
    {
        public string? errorMessage { get; private set; }
        public ErrorResponse(string Error, string informative = "")
        {
            base.isSuccessfull = false;
            errorMessage = Error;
            base.informativeMessage = informative;
        }
    }
}
