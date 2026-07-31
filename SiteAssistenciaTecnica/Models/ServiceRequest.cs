using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteAssistenciaTecnica.Models
{
    [Table("ServiceRequests")]
    public class ServiceRequest
    {
        //public ServiceRequest()
        //{
        //    ServiceId = 0;
        //    CostumerId = 0;
        //    PickUpMachine = false;
        //    DeliveryMachine = false;
        //    MachineBrand = string.Empty;
        //    MachineModel = string.Empty;
        //    MachineSerialNumber = string.Empty;
        //    ProblemDescription = string.Empty;
        //}
        [Key]
        public int Id { get; set; }
        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [Required]
        public bool PickUpMachine { get; set; }
        [Required]
        public bool DeliveryMachine { get; set; }
        [Required]
        public string MachineBrand { get; set; }
        [Required]
        public string MachineModel { get; set; }
        [Required]
        public string MachineSerialNumber { get; set; }
        [Required]
        public string ProblemDescription { get; set; }

    }
}
