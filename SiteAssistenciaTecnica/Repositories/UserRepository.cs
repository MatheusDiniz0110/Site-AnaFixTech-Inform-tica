using SiteAssistenciaTecnica.Models;
using SiteAssistenciaTecnica.Data;
using Microsoft.EntityFrameworkCore;

namespace SiteAssistenciaTecnica.Repositories
{
    public class UserRepository
    {
        public static User Get(string email, string password)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=rvmm\\sqlexpress;Database=SiteAnaFixTech;Trusted_Connection=True;TrustServerCertificate=True;");

            using (var context = new AppDbContext(optionsBuilder.Options))
            {
                return context.Users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower() && u.Password == password);
            }
        }
    }
}
