using Mercator.Data.Domain.AggregateModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercator.Data.Infrastructure
{
    public class MercatorContext : DbContext
    {
        public MercatorContext(DbContextOptions<MercatorContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Terminal> Terminals { get; set; }

    }
}
