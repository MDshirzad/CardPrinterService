using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAdapter
{
    public interface INotifierService
    {
       public event RecieveMessage OnRecievedMessage;
        delegate void RecieveMessage(string recievedMessage);
        public void StartServer();
        public void StopSocket();
        public void SendMessage(string message);

    }
}
