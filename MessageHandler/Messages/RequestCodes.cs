using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Messages
{
    internal class RequestCodes
    {
     
        internal static string Printers_Info_Code = "100";
        internal static string Printer_Ribbon_Eth_Code = "110";
        internal static string Printer_Ribbon_Usb_Code = "120";
        internal static string LoginRequest_Code = "400";
        internal static string Single_K_PrintRequest_ByUsb_Code = "810";
        internal static string Double_K_PrintRequest_ByUsb_Code = "820";
        internal static string Single_KO_PrintRequest_ByUsb_Code = "830";
        internal static string Double_KO_PrintRequest_ByUsb_Code = "840";
        internal static string Single_YMCKO_PrintRequest_ByUsb_Code = "850";
        internal static string Double_YMCKO_PrintRequest_ByUsb_Code = "860";
        internal static string Single_K_PrintRequest_ByEth_Code = "870";
        internal static string Double_K_PrintRequest_ByEth_Code = "880";
        internal static string Single_KO_PrintRequest_ByEth_Code = "890";
        internal static string Double_KO_PrintRequest_ByEth_Code = "900";
        internal static string Single_YMCKO_PrintRequest_ByEth_Code = "910";
        internal static string Double_YMCKO_PrintRequest_ByEth_Code = "920";

        internal static string EjectCard_Request_ByUsb_Code = "210";
        internal static string EjectCard_Request_ByEth_Code = "220";
    }
}
