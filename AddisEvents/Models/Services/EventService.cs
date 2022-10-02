using AddisEvents.Data;
using AddisEvents.Models.Base;

namespace AddisEvents.Models.Services
{
    public class EventService: EntityBaseRepository<Event>, IEventService
    {
        private readonly ApplicationDbContext _context;

        public EventService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
