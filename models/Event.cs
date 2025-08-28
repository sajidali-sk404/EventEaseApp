using System.ComponentModel.DataAnnotations;
namespace EventEase.Models
{
  public class Event
  {
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Location is required")]
    public string Location { get; set; }

    [StringLength(500, ErrorMessage = "Description too long")]
    public string Description { get; set; }
    public List<Registration> Attendees { get; set; } = new();
  }
}
