using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercator.Data.Domain.AggregateModel.Entities
{
    public class Transaction
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public string CardType { get; set; }
        public string RRN { get; set; }
    }
}
