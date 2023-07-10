using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.IServices;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class ProductRepository : IProductRepository
    {
         private readonly StoreContext _context;
         public ProductRepository(StoreContext context)
         {
            _context = context;
         }
        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Prodcuts.ToListAsync();
        }

        public async Task<Product> GetProductsByIdAsync(int id)
        {
          
           return await _context.Prodcuts.FindAsync(id);
        }
    }
}