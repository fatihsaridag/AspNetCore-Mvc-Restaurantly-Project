using Restaurantly.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Shared.Data.Repository.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class  
    {

        List<TEntity> GetList();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        List<TEntity> Where(Expression<Func<TEntity,bool>> predicate);
    }
}
