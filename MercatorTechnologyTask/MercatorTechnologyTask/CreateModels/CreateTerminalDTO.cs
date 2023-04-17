using Mercator.Data.Domain.AggregateModel.Entities;

namespace MercatorTechnologyTask.API.CreateModels
{
    public class CreateTerminalDTO
    {
        public string Terminaltype { get; set; }
        public string Location { get; set; }
        public long MerchantId { get; set; }
    }
}
