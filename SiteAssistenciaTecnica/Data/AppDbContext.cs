using Microsoft.EntityFrameworkCore;
using SiteAssistenciaTecnica.Models;

namespace SiteAssistenciaTecnica.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Uma única linha que representa a tabela inteira do banco de dados
        public DbSet<User> Users { get; set; }
    }
}