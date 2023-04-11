using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercator.Data.Domain.Infrastructure
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(long id);
        void Delete(int id);
        void Add(T entity);
        List<T> GetAll();
        void Update(T entity);
    }
}
