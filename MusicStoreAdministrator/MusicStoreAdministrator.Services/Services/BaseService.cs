using MusicStoreAdministrator.Core.Interfaces.Repositories;
using MusicStoreAdministrator.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreAdministrator.Services.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _baseRepository.AddAsync(entity);
        }

        public Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            //TODO ADD RANGE in REPO
            throw new NotImplementedException();
        }

        public async ValueTask<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _baseRepository.GetAllAsync();
        }

        public async ValueTask<TEntity> GetByIdAsync(int? id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }

        public Task Remove(TEntity entity)
        {
            return _baseRepository.Remove(entity);
        }

        public Task RemoveRange(IEnumerable<TEntity> entities)
        {
            //TODO DELETE RANGE in REPO
            throw new NotImplementedException();
        }

        public async Task Update(int? id, TEntity entityToUpdate)
        {
            await _baseRepository.Update(entityToUpdate);
        }

        public Task UpdateRange(IEnumerable<TEntity> entitiesToUpdate)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
