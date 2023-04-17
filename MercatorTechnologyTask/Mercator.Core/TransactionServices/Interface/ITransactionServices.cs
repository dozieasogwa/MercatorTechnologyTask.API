using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercator.Data.Domain.AggregateModel.Entities;

namespace Mercator.Core.TransactionServices.Interface
{
    public interface ITransactionServices
    {
        Transaction Get(long id);
        void Delete(long id);
        void Add(Transaction entity);
        List<Transaction> GetAll();
        void Update(Transaction entity);
    }
}
