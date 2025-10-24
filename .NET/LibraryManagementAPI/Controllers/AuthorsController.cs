using LibraryManagementAPI.Data.Repository;
using LibraryManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorsController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet("getAll")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<IEnumerable<Author>>> getAll()
        {
            var authors = await _authorRepository.GetAllAsync();
            return Ok(authors);
        }

        [HttpGet("getById")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Author>> getById(int id)
        {
            if(id <= 0)
            {
                return BadRequest();
            }
            var author = await _authorRepository.GetByIdAsync(id);
            if(author == null)
            {
                return NotFound();
            }
            return author;
        }

        [HttpPost("add")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Author>> addAuthor([FromBody] Author newAuthor)
        {
            var author = await _authorRepository.AddAsync(newAuthor);
            return author;
        }

        [HttpPut("update")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Author?>> updateAuthor([FromBody] Author newAuthor)
        {
            if(newAuthor.AuthorId <= 0)
            {
                return BadRequest();
            }

            var author = await _authorRepository.GetByIdAsync(newAuthor.AuthorId);
            if(author == null)
            {
                return NotFound();
            }
            await _authorRepository.UpdateAsync(newAuthor);
            return newAuthor;
        }

        [HttpDelete("delete")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]

        public async Task<ActionResult<bool>> deleteAuthor(int id)
        {
            if(id <= 0)
            {
                return BadRequest();
            }
            var result = await _authorRepository.DeleteAsync(id);
            return result;
        }
    }
}
