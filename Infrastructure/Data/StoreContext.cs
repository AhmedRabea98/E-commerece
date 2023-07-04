using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
namespace Infrastructure.Data
{
    public class StoreContext:DbContext
    {
        
        public StoreContext(DbContextOptions options):base (options)
        {
            
        }
        public DbSet<Product> Prodcuts {get;set;}
    }
}