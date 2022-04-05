namespace login.model
{
  public class User
  {
    public string? Name { get; set; }
    private string? _Password { get; set; }
    public bool ValidatePassword(string input)
    {
      return input == _Password;
    }


    public User(string? name, string? password)
    {
      Name = name;
      _Password = password;
    }
  }
}