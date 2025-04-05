using System.Text;

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
        public string FrontColoredImage { get; set; } = string.Empty;
        public bool HasMagn { get; set; } = true;
        public string extraData
        {
            get => _extraData;
            set
            {
                _extraData = value;
                setIfCoordination();
            }
        }
        private string _extraData = string.Empty;
        public string ConnectionType { get; set; } = "USB";
        internal double  X { get; set; }
        internal double Y { get; set; }  
        private void setIfCoordination()
        {
            if (!string.IsNullOrEmpty(_extraData)&& _extraData.Split(",").Length == 2)
            {
                var splited = _extraData.Split(",");
                double parsedX = default;
                double parsedY = default;
                var IsValidX = double.TryParse(Encoding.UTF8.GetBytes(splited[0]),out parsedX);
                var IsValidY = double.TryParse(Encoding.UTF8.GetBytes(splited[1]), out parsedY);
                if(IsValidX && IsValidY)
                {
                    X = parsedX;
                    Y = parsedY;
                }
                
            }
        }
    }
    internal  record NonJsonRequest:BaseCommand;
}
