using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        Task AddAsync(TEntity entity);

        Task EditAsync(TEntity entity);

        Task<IList<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(Guid id);

        Task RemoveAsync(TEntity entity);
    }
}
