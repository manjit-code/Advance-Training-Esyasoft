using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API_CollegeApp.Data.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(int id,T entity);
        Task<bool> DeleteAsync(int id);
        Task<T> GetByNameAsync(string name);
    }
}
