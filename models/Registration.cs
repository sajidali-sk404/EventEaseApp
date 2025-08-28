using System.ComponentModel.DataAnnotations;

public class Registration
{
  [Required(ErrorMessage = "Name is required")]
  public string Name { get; set; }
  
  [Required(ErrorMessage = "Email is required")]
  [EmailAddress(ErrorMessage = "Valid email required")]
  public string Email { get; set; }

  public Guid EventId { get; set; }
}
