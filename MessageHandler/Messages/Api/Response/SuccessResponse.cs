namespace MessageHandler.Messages.Api.Response
{
    internal class SuccessResponse : BaseResponse
    {
        public object? data { get; set; }
        public SuccessResponse(string InformativeMessage, object? data = null)
        {
            informativeMessage = InformativeMessage;
            isSuccessfull = true;
            this.data = data;

        }
    }
}
