using Mercator.Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercator.Data.Domain.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MercatorContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(MercatorContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }

        public  T Get(long id)
        {
            return  _dbSet.Find(id);
        }

        public List<T> GetAll()
        {
            IQueryable<T> query = _dbSet;
            return query.ToList();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
