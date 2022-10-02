using AddisEvents.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace AddisEvents.Models
{
    public class Event:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventType { get; set; }
        public DateTime EventDate { get; set; }
        public string EventDescription { get; set; }
        public string Address { get; set; }
        public string OtherInfo { get; set; }

    }
}
