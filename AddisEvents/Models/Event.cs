using AddisEvents.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace AddisEvents.Models
{
    public class Event:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "*Event Name Required")]
        [Display(Name = "Event Name")]
        [StringLength(100)]
        public string EventName { get; set; }

        [Required(ErrorMessage ="*Event Type Required")]
        [Display(Name ="Event Type")]
        public string EventType { get; set; }

        [Required(ErrorMessage ="*Event Date Required")]
        [Display(Name ="Event Date")]
        public DateTime EventDate { get; set; }

        [Display(Name ="Event Description")]
        [StringLength(500)]
        public string EventDescription { get; set; }

        [Required(ErrorMessage ="*Address Required")]
        [Display(Name ="Address")]
        public string Address { get; set; }

        [Display(Name ="Other Info")]
        [StringLength(200)]
        public string OtherInfo { get; set; }

    }
}
