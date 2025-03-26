using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Response
{
    internal class SuccessResponse:BaseResponse
    {
        public object? data { get; set; }
        public SuccessResponse(string InformativeMessage ,object? data=null)
        {
            base.informativeMessage = InformativeMessage;
            base.isSuccessfull = true;
            this.data = data;
            
        }
    }
}
