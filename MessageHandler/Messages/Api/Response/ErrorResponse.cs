namespace MessageHandler.Messages.Api.Response
{
    internal class ErrorResponse : BaseResponse
    {
      
        public ErrorResponse(string InformaiveMessage )
        {
            isSuccessfull = false;
            
            informativeMessage = InformaiveMessage;
        }
    }
}
