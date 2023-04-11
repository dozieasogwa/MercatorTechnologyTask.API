using Mercator.Data.Domain.AggregateModel.Entities;
using Mercator.Data.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercator.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MercatorContext _context;
        private IGenericRepository<Merchant> _merchants;
        private IGenericRepository<Terminal> _terminals;
        private IGenericRepository<Transaction> _transactions;

        public UnitOfWork(MercatorContext context)
        {
            _context = context;
        }
        public IGenericRepository<Merchant> Marchants => _merchants?? new GenericRepository<Merchant>(_context);

        public IGenericRepository<Terminal> Terminals => _terminals??  new GenericRepository<Terminal>(_context);

        public IGenericRepository<Transaction> Transactions => _transactions?? new GenericRepository<Transaction>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task  Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
