using InventoryManagementSystem.Data.Repository;
using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IGenericRepository<Product> _repository;

        public ProductsController(IGenericRepository<Product> repository)
        {
            _repository = repository;
        }

        [HttpGet("getAll")]
        public ActionResult<IEnumerable<Product>> GetAll() 
        { 
            var products = _repository.GetAll();
            return Ok(products);
        }

        [HttpGet("getById")]
        public ActionResult<Product> getById(int id)
        {
            var product = _repository.GetById(id);
            return Ok(product);
        }

        [HttpPost("add")]
        public ActionResult<Product> addProduct([FromBody] Product product) 
        {
            _repository.Add(product);
            _repository.Save();
            return Ok(product);

        }

        [HttpPut("update")]
        public ActionResult<Product> updateProduct([FromBody] Product product)
        {
            _repository.Update(product);
            _repository.Save();
            return Ok(product);
        }
        [HttpDelete("delete")]
        public ActionResult deleteProduct(int id) { 
            _repository.Delete(id);
            _repository.Save();
            return Ok();
        }
    }
}
