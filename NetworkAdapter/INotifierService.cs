namespace NetworkAdapter
{
    public interface INotifierService
    {
        public event RecieveMessage OnRecievedMessage;
        delegate Task RecieveMessage(string recievedMessage);
        public void StartServer();
        public void StopSocket();
        public void SendMessage(string message);

    }
}
