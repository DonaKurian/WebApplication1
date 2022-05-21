using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        ApplicationDBContext _dbContext;
        [HttpPost("AddCategory")]
        public async Task<Category>  Create_Category(Category category)
        {
            var obj = await _dbContext.category.AddAsync(category);
            _dbContext.SaveChanges();
            return obj.Entity;
        }
        [HttpPost("AddProducts")]
        public async Task<Products> Create_Products(Products products)
        {
            var obj = await _dbContext.products.AddAsync(products);
            _dbContext.SaveChanges();
            return obj.Entity;
        }
        [HttpPost("GetAll")]
        public IEnumerable<Category> GetAll()
        {
            try
            {
                return _dbContext.category.Where(x => x.IsActive == true).ToList();
            }
            catch (Exception ee)
            {
                throw;
            }
        }
        [HttpPost("UpdateProduts")]
        public void Update_products(Products products)
        {
            _dbContext.products.Update(products);
            _dbContext.SaveChanges();
        }
        [HttpPost("DeleteProducts")]
        public void Delete_products(Products products)
        {
            _dbContext.Remove(products);
            _dbContext.SaveChanges();
        }

   
       
    }
}
