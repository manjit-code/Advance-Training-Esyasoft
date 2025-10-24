using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Data.Repository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAllAsync();
        Task<Author?> GetByIdAsync(int authorId);
        Task<Author> AddAsync(Author author);
        Task<Author?> UpdateAsync(Author author);
        Task<bool> DeleteAsync(int authorId);
    }
}
