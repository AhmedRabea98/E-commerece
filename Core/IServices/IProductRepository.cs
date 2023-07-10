using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  Core.Entities;
namespace Core.IServices
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<Product> GetProductsByIdAsync(int id);

    }
}