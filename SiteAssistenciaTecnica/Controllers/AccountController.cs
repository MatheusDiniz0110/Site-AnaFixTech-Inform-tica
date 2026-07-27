using Microsoft.AspNetCore.Mvc;
using SiteAssistenciaTecnica.Models;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace SiteAssistenciaTecnica.Controllers
{
    public class AccountController : Controller
    {
        private readonly HttpClient _httpClient;

        public AccountController(
            IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("Api");
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {

            var json = JsonSerializer.Serialize(new
            {
                email = model.Email,
                password = model.Password
            });


            var content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );


            var response = await _httpClient.PostAsync(
                "/login",
                content
            );


            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(
                    "",
                    "Email ou senha inválidos"
                );

                return View(model);
            }


            var result = await response.Content.ReadAsStringAsync();


            var data = JsonSerializer.Deserialize<LoginResponse>(
                result
            );


            // guardar token
            HttpContext.Session.SetString(
                "JWT",
                data.token
            );


            return RedirectToAction(
                "Index",
                "Home"
            );
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("JWT");

            return RedirectToAction(
                "Login"
            );
        }
    }
}