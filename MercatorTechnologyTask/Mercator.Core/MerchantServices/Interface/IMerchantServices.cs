using Mercator.Data.Domain.AggregateModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercator.Core.MerchantServices.Interface
{
    public interface IMerchantServices
    {
        Merchant Get(long id);
        void Delete(long id);
        void Add(Merchant entity);
        List<Merchant> GetAll();
        void Update(Merchant entity);
    }
}
