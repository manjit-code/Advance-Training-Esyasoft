using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly EmployeeDbContext _employeeContext;

        public UserRepository(EmployeeDbContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public async Task<User> GetUserAsync(string username)
        {
            var user = await _employeeContext.Users.Where(u => u.UserName == username).FirstOrDefaultAsync();
            return user;
        }
    }
}
