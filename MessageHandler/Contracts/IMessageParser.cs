namespace MessageHandler.Contracts
{
    public interface IMessageParser
    {
        public Task<object> ParseMessage(string message);
    }
}
