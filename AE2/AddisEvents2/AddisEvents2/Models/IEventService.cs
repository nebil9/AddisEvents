namespace AddisEvents2.Models
{
    public interface IEventService
    {
        List<Event> GetAll();
        void Add(Event Event);
        Event GetById(int id);
        Event Update(int id, Event @event);
        void Delete(int id);
    }
}
