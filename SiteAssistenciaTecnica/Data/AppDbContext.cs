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

// OBS: Atualizamos AppDbContext para herdar IdentityDbContext.
// Mantivemos o registro AddDbContext<AppDbContext> em Program.cs para que
// os serviços do Identity usem esse contexto (AddEntityFrameworkStores<AppDbContext>).
