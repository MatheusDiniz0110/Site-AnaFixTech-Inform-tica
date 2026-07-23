using SiteAssistenciaTecnica.Models;
using SiteAssistenciaTecnica.Data;
using Microsoft.EntityFrameworkCore;

namespace SiteAssistenciaTecnica.Repositories
{
    public class UserRepository
    {
        private readonly AppDbContext _context;

        // O construtor recebe o seu contexto corrigido
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        // QUERY 1: Buscar um usuário específico pelo ID
        public async Task<User?> ObterPorIdAsync(int id)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        // QUERY 2: Buscar por Username e Password (Útil para a tela de Login)
        public async Task<User?> ValidarLoginAsync(string username, string password)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
        }

        // QUERY 3: Listar TODOS os usuários ativos do banco
        public async Task<List<User>> ObterTodosAtivosAsync()
        {
            return await _context.Users
                .Where(u => u.isActive == true)
                .ToListAsync();
        }

        // QUERY 4: Buscar usuários por parte do nome (Filtro de busca)
        public async Task<List<User>> BuscarPorNomeAsync(string termoBusca)
        {
            return await _context.Users
                .Where(u => u.Name.Contains(termoBusca))
                .ToListAsync();
        }


    }
}
