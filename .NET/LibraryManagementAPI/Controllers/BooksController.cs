using LibraryManagementAPI.Data.Repository;
using LibraryManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("getAll")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<IEnumerable<Book>>> getAll()
        {
            var books = await _bookRepository.GetAllAsync();
            return Ok(books);
        }

        [HttpGet("getById")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Book>> getById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var book = await _bookRepository.GetByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        [HttpPost("add")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Book>> addBook([FromBody] Book newBook)
        {
            var book = await _bookRepository.AddAsync(newBook);
            return book;
        }

        [HttpPut("update")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Book?>> updateBook([FromBody] Book newBook)
        {
            if (newBook.BookId <= 0)
            {
                return BadRequest();
            }

            var book = await _bookRepository.GetByIdAsync(newBook.BookId);
            if (book == null)
            {
                return NotFound();
            }
            await _bookRepository.UpdateAsync(newBook);
            return newBook;
        }

        [HttpDelete("delete")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]

        public async Task<ActionResult<bool>> deleteBook(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var result = await _bookRepository.DeleteAsync(id);
            return result;
        }
    }
}
