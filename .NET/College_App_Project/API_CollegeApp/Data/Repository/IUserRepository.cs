using API_CollegeApp.Models;

namespace API_CollegeApp.Data.Repository
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(string username);
    }
}
