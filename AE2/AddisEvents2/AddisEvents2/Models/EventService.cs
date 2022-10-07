using Microsoft.EntityFrameworkCore;

namespace AddisEvents2.Models
{
    public class EventService : IEventService
    {
        private readonly AppDbContext _context;

        public EventService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Event Event)
        {
            _context.Events.Add(Event);
            _context.SaveChanges();
        }

        public List<Event> GetAll()
        {
            var result = _context.Events.Include(c => c.Category).ToList();

            return result;
        }

        public Event GetById(int id)
        {
            var result = _context.Events.Find(id);

            return result;
        }

        public Event Update(int id, Event @event)
        {
            _context.Update(@event);
            _context.SaveChanges();

            return @event;
        }

        public void Delete(int id)
        {
            var del = _context.Events.Find(id);
            _context.Events.Remove(del);
            _context.SaveChanges();
        }
    }
}
