namespace MessageHandler.Contracts
{
    internal abstract record BasePrinterCommand : BaseCommand
    {
        public string PrinterName { get; set; } = string.Empty;
        public string Track1 { get; set; } = string.Empty;
        public string Track2 { get; set; } = string.Empty;
        public string Track3 { get; set; } = string.Empty;
        public string FrontImage { get; set; } = string.Empty;
        public string BackImage { get; set; } = string.Empty;
        public string BackColoredImage { get; set; } = string.Empty;
        public string FrontColoredImage { get; set;} = string.Empty;
        public bool HasMagn { get; set; } = true;
        public string extraData { get; set; } = string.Empty;
        public string ConnectionType { get;set; } = "USB";
    }

}
