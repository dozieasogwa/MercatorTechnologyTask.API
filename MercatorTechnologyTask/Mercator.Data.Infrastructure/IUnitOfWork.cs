using Mercator.Data.Domain.AggregateModel.Entities;
using Mercator.Data.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercator.Data.Infrastructure
{
    public interface IUnitOfWork: IDisposable
    {
        IGenericRepository<Merchant> Marchants { get; }
        IGenericRepository<Terminal> Terminals { get; }
        IGenericRepository<Transaction> Transactions { get; }
        Task Save();
    }
}
