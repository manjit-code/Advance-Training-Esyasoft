using LibraryManagementAPI.Models;

namespace LibraryManagementAPI.Data.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int bookId);
        Task<Book> AddAsync(Book book);
        Task<Book?> UpdateAsync(Book book);
        Task<bool> DeleteAsync(int bookId);
    }
}
