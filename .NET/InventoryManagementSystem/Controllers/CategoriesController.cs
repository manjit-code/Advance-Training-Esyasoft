using InventoryManagementSystem.Data.Repository;
using InventoryManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IGenericRepository<Category> _repository;

        public CategoriesController(IGenericRepository<Category> repository)
        {
            _repository = repository;
        }

        [HttpGet("getAll")]
        public ActionResult<IEnumerable<Category>> GetAll()
        {
            var categorys = _repository.GetAll();
            return Ok(categorys);
        }

        [HttpGet("getById")]
        public ActionResult<Category> getById(int id)
        {
            var category = _repository.GetById(id);
            return Ok(category);
        }

        [HttpPost("add")]
        public ActionResult<Category> addCategory([FromBody] Category category)
        {
            _repository.Add(category);
            _repository.Save();
            return Ok(category);

        }

        [HttpPut("update")]
        public ActionResult<Category> updateCategory([FromBody] Category category)
        {
            _repository.Update(category);
            _repository.Save();
            return Ok(category);
        }
        [HttpDelete("delete")]
        public ActionResult deleteCategory(int id)
        {
            _repository.Delete(id);
            _repository.Save();
            return Ok();
        }
    }
}
