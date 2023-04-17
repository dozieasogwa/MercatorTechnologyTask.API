namespace MercatorTechnologyTask.API.ReturnMerchantModel
{
    public class TransactionReturnDTO
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public string CardType { get; set; }
        public string RRN { get; set; }
    }
}
