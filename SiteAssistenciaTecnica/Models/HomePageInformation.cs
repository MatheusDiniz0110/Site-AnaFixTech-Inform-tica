namespace SiteAssistenciaTecnica.Models
{
    public class HomePageInformation
    {
        public HomePageInformation()
        {
            ServicesPerformed = 0;
            SatisfiedCustomers = 0;
            DeliveryTime = 0;
            SatisfactionIndex = 0;
        }

        public int Id { get; set; }
        public int ServicesPerformed { get; set; }
        public int SatisfiedCustomers { get; set; }
        public int DeliveryTime { get; set; }
        public int SatisfactionIndex { get; set; }
    }
}
