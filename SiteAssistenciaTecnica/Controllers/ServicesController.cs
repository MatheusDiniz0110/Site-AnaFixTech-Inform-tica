using Microsoft.AspNetCore.Mvc;
using SiteAssistenciaTecnica.Data;
using Microsoft.EntityFrameworkCore;

namespace SiteAssistenciaTecnica.Controllers
{
    public class ServicesController : Controller
    {

        private readonly AppDbContext _context;
        public ServicesController(AppDbContext context) => _context = context;

        public async Task<IActionResult> Index() 
        {
            var servicos = await _context.Services.ToListAsync();
            return View(servicos);
        }
    }
}
