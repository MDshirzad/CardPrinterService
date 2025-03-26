using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Response
{
    internal class ErrorResponse:BaseResponse
    {
        public string? errorMessage { get; private set; }
        public ErrorResponse(string Error,string informative ="")
        {
            base.isSuccessfull = false;
            errorMessage = Error;
            base.informativeMessage = informative;
        }
    }
}
