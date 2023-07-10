using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.IServices;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController:ControllerBase
    {
            private readonly IProductRepository _Repository;
            public ProductsController(IProductRepository Repository)
            {
                _Repository = Repository;
            }
               
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts(){
            var products = await _Repository.GetProductsAsync();
            return Ok(products);
        }


       [HttpGet("{id}")]  
        public async Task<ActionResult<Product>> GetProduct(int id){
            var product = await _Repository.GetProductsByIdAsync(id);
            return product;
        }
    }
}