using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task AddAsync(Product entity);

        Task EditAsync(Product entity);

        Task<IList<Product>> GetAllAsync();

        Task<Product> GetByIdAsync(Guid id);

        Task RemoveAsync(Product entity);
    }
}
