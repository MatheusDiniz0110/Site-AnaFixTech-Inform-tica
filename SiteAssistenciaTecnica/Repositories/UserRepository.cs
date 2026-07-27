using SiteAssistenciaTecnica.Models;
using SiteAssistenciaTecnica.Data;
using Microsoft.EntityFrameworkCore;

namespace SiteAssistenciaTecnica.Repositories
{
    public class UserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public User Get(string email, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower() && u.Password == password);
        }
    }
}
