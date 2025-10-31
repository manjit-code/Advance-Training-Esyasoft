using API_CollegeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CollegeApp.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly CollegeDbContext _collegeDb;

        public UserRepository(CollegeDbContext collegeDb)
        {
            _collegeDb = collegeDb;
        }
        public async Task<User> GetUserAsync(string username)
        {
            var user = await _collegeDb.Users.Where(u => u.UserName == username).FirstOrDefaultAsync();
            return user;
        }
    }
}
