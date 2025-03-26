using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Response
{
    internal class BaseResponse
    {
        public bool isSuccessfull { get; protected set; } 
        
        public string? informativeMessage { get; set; }
       
    }
}
