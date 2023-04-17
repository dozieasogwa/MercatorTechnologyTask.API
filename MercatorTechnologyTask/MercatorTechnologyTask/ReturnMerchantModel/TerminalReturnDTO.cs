namespace MercatorTechnologyTask.API.ReturnMerchantModel
{
    public class TerminalReturnDTO
    {
        public long Id { get; set; }
        public string Terminaltype { get; set; }
        public string Location { get; set; }
        public long MerchantId { get; set; }
    }
}
