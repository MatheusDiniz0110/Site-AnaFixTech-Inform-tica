namespace SiteAssistenciaTecnica.Models
{
    public class Login
    {
        public Login()
        {
            Email = string.Empty;
            Password = string.Empty;
        }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
