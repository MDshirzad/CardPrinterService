using Fleck;
using Logging;

namespace NetworkAdapter
{
    internal class NotifierServer : INotifierService
    {
        public event INotifierService.RecieveMessage? OnRecievedMessage;

        public void SendMessage(string message)
        {
            if (_socket != null && _socket.IsAvailable)
                _socket.Send(message);
        }

        public void StopSocket()
        {
            //  _socket.Close();
            server?.ListenerSocket.Close();
            server?.Dispose();
        }

        WebSocketServer? server;
        IWebSocketConnection? _socket;
        void INotifierService.StartServer()
        {
            server = new WebSocketServer("ws://0.0.0.0:9697");
            server.Start(socket =>
            {
                _socket = socket;
                socket.OnOpen = () => LogWriter.WriteTransactionInfo("New Connection Recieved");
                socket.OnClose = () => LogWriter.WriteTransactionInfo("Connection Closed");
                socket.OnMessage = message =>
                {
                    LogWriter.WriteTransactionInfo($"Message Recieved:{message}");
                    OnRecievedMessage?.Invoke(message);
                };
            });
        }


    }
}
