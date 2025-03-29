using MessageHandler.Contracts;

namespace MessageHandler.Handlers.SingleSideKHandle
{
    internal record SingleSideKCommand : BasePrinterCommand {
        public string frontImage { get; set; } = string.Empty;
    };
}
