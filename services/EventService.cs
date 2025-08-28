using EventEase.Models;

namespace EventEase.Services
{
  public class EventService : IEventService
  {
    private readonly List<Event> _events = new()
    {
      new Event
      {
        Title = "Corporate Summit",
        Date = DateTime.Today.AddDays(7),
        Location = "Karachi Expo Center",
        Description = "Annual corporate strategy summit.",
      },
      new Event
      {
        Title = "Social Gala",
        Date = DateTime.Today.AddDays(14),
        Location = "Lahore Banquet Hall",
        Description = "Fundraising gala for local charities.",
      },
      new Event
      {
        Title = "Tech Meetup",
        Date = DateTime.Today.AddDays(21),
        Location = "Islamabad Convention Center",
        Description = "Monthly meetup for tech enthusiasts.",
      }
    };

    public Event SelectedEvent { get; set; }
    public List<Registration> Registrations { get; set; } = new();
    public Task<List<Event>> GetAll() => Task.FromResult(_events);

    public Task<Event> GetById(Guid id) =>
      Task.FromResult(_events.FirstOrDefault(e => e.Id == id));

 public Task AddRegistration(Guid eventId, Registration reg)
{
  var ev = _events.FirstOrDefault(e => e.Id == eventId);
  ev?.Attendees.Add(reg);
  return Task.CompletedTask;
}


    public Task Add(Event newEvent)
    {
      _events.Add(newEvent);
      return Task.CompletedTask;
    }
  }
}
