using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SiteAssistenciaTecnica.Models
{
    [Table("Services")]
    public class Service
    {
        //public Services()
        //{
        //    Class = string.Empty;
        //    Title = string.Empty;
        //    Description = string.Empty;
        //    Price = 0;
        //}
        [Key]
        public int Id { get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Decimal Price { get; set; }
    }
}
