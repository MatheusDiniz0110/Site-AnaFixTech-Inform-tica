namespace SiteAssistenciaTecnica.Models
{
    public class Service
    {
        public Service()
        {
            Class = string.Empty;
            Title = string.Empty;
            Description = string.Empty;
            Price = 0;
        }
        public int Id { get; set; }
        public string Class { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
