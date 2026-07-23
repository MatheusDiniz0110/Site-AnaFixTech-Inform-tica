using Microsoft.AspNetCore.Mvc;

namespace SiteAssistenciaTecnica.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
