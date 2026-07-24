using Microsoft.AspNetCore.Mvc;

namespace SiteAssistenciaTecnica.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public bool ChecarTokenNoHeader()
        {
            // 1. Busca o cabeçalho "Authorization"
            string authHeader = Request.Headers["Authorization"];

            // 2. Verifica se ele existe e começa com "Bearer "
            if (!string.IsNullOrEmpty(authHeader) && authHeader.StartsWith("Bearer "))
            {
                // Extrai apenas o texto do token (remove o prefixo "Bearer ")
                string token = authHeader.Substring("Bearer ".Length).Trim();

                return true;
            }

            return false;
        }
    }
}
