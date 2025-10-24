using LibraryManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _dbcontext;

        public BookRepository(LibraryDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<Book> AddAsync(Book book)
        {
            _dbcontext.BookTable.Add(book);
            await _dbcontext.SaveChangesAsync();
            return book;
        }

        public async Task<bool> DeleteAsync(int bookId)
        {
            var book = await _dbcontext.BookTable.Where(a => a.BookId == bookId).FirstOrDefaultAsync();
            if (book == null)
            {
                return false;
            }
            _dbcontext.BookTable.Remove(book);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            var books = await _dbcontext.BookTable.Select(b => new Book()
            {
                BookId = b.BookId,
                Title = b.Title,
                Genre = b.Genre
            }).ToListAsync();
            return books;
        }

        public async Task<Book?> GetByIdAsync(int bookId)
        {
            var book = await _dbcontext.BookTable.Where(a => a.BookId == bookId).FirstOrDefaultAsync();
            return book;
        }

        public async Task<Book?> UpdateAsync(Book book)
        {
            var existingBook = await _dbcontext.BookTable.Where(a => a.BookId == book.BookId).FirstOrDefaultAsync();
            existingBook.Title = book.Title;
            existingBook.Genre = book.Genre;
            await _dbcontext.SaveChangesAsync();
            return existingBook;
        }
    }
}
