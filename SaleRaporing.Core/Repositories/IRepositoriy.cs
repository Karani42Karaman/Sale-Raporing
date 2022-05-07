using System;
using System.Collections.Generic;
using System.Linq.Expressions; 
using System.Threading.Tasks;

namespace SaleRaporing.Core.Repositories
{

    public interface IRepositoriy<TEntity> where TEntity : class
    {

        ValueTask<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        Task AddAsync(TEntity model);

        Task AddRangeAsync(IEnumerable<TEntity> models);

        void Remove(TEntity model);

        void RemoveRange(IEnumerable<TEntity> models);

    }
}
