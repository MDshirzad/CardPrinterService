 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Messages.ResponseMessages
{
    internal class FunctionResponse
    {
   
        internal const string InvalidTracks = "خطای ترک";

        internal const string EMPTY_FEEDER = "فیدر خالی از کارت میباشد";
        internal const string ERROR_PRINTER_CONNECTION = "خطا در اتصال به پرینتر";
        internal const string SUCCESSFULL_PRINT_OPERATION = "پرینت با موفقیت انجام شد";
        internal const string INVALID_FORMAT = "فرمت نامعتبر";
        internal const string INNER_EXCEPTION = "خطای داخلی";
        internal const string UNHANDLED_MESSAGE = "خطای ناشناخته";
        internal const string SUCCESS_RESPONSE= "عملیات با موفقیت انجام شد";
    }
}
