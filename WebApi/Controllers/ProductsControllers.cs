using Entity;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    
    [ApiController]
    
    public class ProductsControllers : ControllerBase
    {
        IProductService productService;
        public ProductsControllers(IProductService productService)
        {
            this.productService = productService;
        }
        // GET: api/<ProductsControllers>
        [HttpGet]

        
        public async Task<ActionResult<(List<Product> Items, int TotalCount)>> Get([FromQuery]int positon, int skip, string? desc, int? minPrice, int? maxPrice, int?[] categoryIds)
        {
            (List<Product> Items, int TotalCount) products = await productService.Get(positon, skip, desc, minPrice, maxPrice, categoryIds);
          
            if (products.Items != null)
                return Ok(products);
            else 
                return NotFound();
        }

        // GET api/<ProductsControllers>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "";
        }

        // POST api/<ProductsControllers>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsControllers>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsControllers>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
