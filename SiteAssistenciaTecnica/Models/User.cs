using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SiteAssistenciaTecnica.Models
{
    [Table("Users")]
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
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Devices { get; set; }
        [Required]
        public bool isAdmin { get; set; } = false;
        [Required]
        public bool isActive { get; set; } = true;
    }
}
