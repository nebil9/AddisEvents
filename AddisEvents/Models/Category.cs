using AddisEvents.Models.Base;

namespace AddisEvents.Models
{
    public class Category:IEntityBase 
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
