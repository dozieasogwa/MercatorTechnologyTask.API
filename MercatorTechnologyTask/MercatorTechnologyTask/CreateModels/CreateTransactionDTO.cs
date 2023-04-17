namespace MercatorTechnologyTask.API.CreateModels
{
    public class CreateTransactionDTO
    {
        public decimal Amount { get; set; }
        public string CardType { get; set; }
        public string RRN { get; set; }
    }
}
