using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ProductService : IProductService
    {
        protected readonly IBaseRepository<Product> _baseRepository;

        public ProductService(IBaseRepository<Product> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task AddAsync(Product entity)
        {
            await _baseRepository.AddAsync(entity);
        }

        public async Task EditAsync(Product entity)
        {
            await _baseRepository.EditAsync(entity);
        }

        public async Task<IList<Product>> GetAllAsync()
        {
            return await _baseRepository.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            return await _baseRepository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(Product entity)
        {
            await _baseRepository.RemoveAsync(entity);
        }
    }
}
