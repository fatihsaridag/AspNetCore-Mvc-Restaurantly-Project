using Microsoft.EntityFrameworkCore;
using Restaurantly.Shared.Data.Repository.Abstract;
using Restaurantly.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Shared.Data.Repository.Concrete
{
     public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class  
    {

        protected readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
             _context.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetList()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
        }

        public List<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }
    }
}
