public class UserSessionTracker
{
  public string CurrentUserName { get; set; }
  public List<Registration> MyRegistrations { get; set; } = new();
}
