using Microsoft.EntityFrameworkCore;
using SalesManagement.Entity;
using System.Threading.Tasks;

namespace SalesManagement.DAL
{
    public class UserDAL
    {
        public async Task<User?> GetUserAsync(string username, string password)
        {
            using (var context = new SalesDbContext())
            {
                return await context.Users
                    .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
            }
        }
    }
}