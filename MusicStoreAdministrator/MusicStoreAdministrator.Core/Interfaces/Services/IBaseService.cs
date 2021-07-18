using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Core.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        ValueTask<TEntity> GetByIdAsync(int? id);
        ValueTask<IEnumerable<TEntity>> GetAllAsync();

        //para que sirve esto
        // Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null,
        //                                       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        //                                     string includeProperties = "");
        //Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task Remove(TEntity entity);
        Task RemoveRange(IEnumerable<TEntity> entities);
        Task Update(int? id, TEntity entityToUpdate);
        Task UpdateRange(IEnumerable<TEntity> entitiesToUpdate);
    }
}
