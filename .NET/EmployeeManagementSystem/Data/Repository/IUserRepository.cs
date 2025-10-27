using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Data.Repository
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(string username);
    }
}
