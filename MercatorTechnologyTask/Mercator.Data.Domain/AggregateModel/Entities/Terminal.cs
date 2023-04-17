using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercator.Data.Domain.AggregateModel.Entities
{
    public class Terminal
    {
        public long Id { get; set; }
        public string Terminaltype { get; set; }
        public string Location { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public virtual Merchant Merchant { get; set; }
        public long MerchantId { get; set; }
    }
}
