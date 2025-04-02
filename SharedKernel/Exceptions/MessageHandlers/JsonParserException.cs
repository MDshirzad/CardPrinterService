namespace SharedKernel.Exceptions.MessageHandlers
{
    public class JsonParserException : BaseException
    {
        const string JsonException = "Invalid Json Object Detected";
        public JsonParserException(string message = JsonException) : base(message)
        {

        }
    }
}
