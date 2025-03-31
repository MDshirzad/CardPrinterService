namespace MessageHandler.Messages.Api
{
    internal class RequestCodes
    {

        internal const string Printers_Info_Code = "100";
        internal const string Printer_Ribbon = "110";
        internal const string Printer_Ribbon_Usb_Code = "120";

        internal const string Single_K_Code = "810";
        internal const string Double_K_Code = "820";
        internal const string Single_KO_Code = "830";
        internal const string Double_KO_Code = "840";
        internal const string Single_YMCKO_Code = "850";
        internal const string Double_YMCKO_Code = "860";

        internal const string EjectCard_Request_Code = "210";

        internal const string LaserPrint_Code = "930";
        internal const string LaserPrintWithRoller_Code = "940";
        internal const string LaserPrintDoubleSideWithoutRibbonWithRoller = "945";

        internal const string LaserPrintWithRollerWithSingleSideYmckoRibbon_Code = "950";

        internal const string LaserPrintWithRollerWithDoubleSideYmckoRibbon_Code = "960";

        internal const string DoubleLaserPrintWithRollerWithSingleSideYmckoRibbon_Code = "970";
        internal const string DoubleLaserPrintWithRollerWithDoubleSideYmckoRibbon_Code = "980";
        internal const string BackSideLaserWithRoller_Code = "990";
    }
}
