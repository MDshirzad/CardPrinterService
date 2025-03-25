using Fleck;
using Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAdapter
{
    internal class NotifierServer : INotifierService
    {
        public event INotifierService.RecieveMessage OnRecievedMessage;

        public void SendMessage(string message)
        {
            if(_socket.IsAvailable)
                _socket.Send(message);
        }

        public void StopSocket()
        {
          //  _socket.Close();
            server.ListenerSocket.Close();
            server.Dispose();
        }

        WebSocketServer server;
        IWebSocketConnection _socket;
        void INotifierService.StartServer()
        {
             server = new WebSocketServer("ws://0.0.0.0:9697");
            server.Start(socket =>
            {
                _socket=socket;
                socket.OnOpen = () =>LogWriter.WriteTransactionInfo("New Connection Recieved");
                socket.OnClose = () => LogWriter.WriteTransactionInfo("Connection Closed");
                socket.OnMessage = message => {
                    LogWriter.WriteTransactionInfo($"Message Recieved:{message}");
                    OnRecievedMessage.Invoke(message);
                };
            });
        }

        
    }
}
