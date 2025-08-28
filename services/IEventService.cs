using EventEase.Models;

namespace EventEase.Services
{
  public interface IEventService
  {
    Task<List<Event>> GetAll();
    Task<Event> GetById(Guid id);
    Task Add(Event newEvent);
    Task AddRegistration(Guid eventId, Registration reg);

    
  }
}
