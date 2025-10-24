using LibraryManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Data.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryDbContext _dbcontext;

        public AuthorRepository(LibraryDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Author> AddAsync(Author author)
        {
            _dbcontext.AuthorTable.Add(author);
            await _dbcontext.SaveChangesAsync();
            return author;
        }

        public async Task<bool> DeleteAsync(int authorId)
        {
            var author = await _dbcontext.AuthorTable.Where(a => a.AuthorId == authorId).FirstOrDefaultAsync();
            if(author == null)
            {
                return false;
            }
            _dbcontext.AuthorTable.Remove(author);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            var authors = await _dbcontext.AuthorTable.Select(a => new Author()
            {
                AuthorId = a.AuthorId,
                Name = a.Name,
                Country = a.Country
            }).ToListAsync();
            return authors;
        }

        public async Task<Author?> GetByIdAsync(int authorId)
        {
            var author = await _dbcontext.AuthorTable.Where(a => a.AuthorId == authorId).FirstOrDefaultAsync();
            return author;
        }

        public async Task<Author?> UpdateAsync(Author author)
        {
            var existingAuthor = await _dbcontext.AuthorTable.Where(a => a.AuthorId == author.AuthorId).FirstOrDefaultAsync();
            existingAuthor.Name = author.Name;
            existingAuthor.Country = author.Country;
            await _dbcontext.SaveChangesAsync();
            return existingAuthor;
        }
    }
}
