namespace SiteAssistenciaTecnica.Models
{
    public class User
    {
        public User()
        {
            Username = string.Empty;
            Name = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Devices = string.Empty;
            isAdmin = false;
            isActive = true;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Devices { get; set; }
        public bool isAdmin { get; set; } = false;
        public bool isActive { get; set; } = true;
    }
}
