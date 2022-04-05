// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

// class UserPerson
// {

//   Dictionary<string, UserPerson> user = new Dictionary<string, UserPerson>(){

//   };

//   static void Main(string[] args)
//   {
//     String username;
//     String password;
//     Console.WriteLine("Enter your username");
//     username = "";

//     username = Console.ReadLine();
//     username = username.ToLower();
//     Console.WriteLine("Enter your password");
//     password = "";
//     password = Console.ReadLine();
//     password = password.ToLower();

//     user.Add(username, password);
//   }

// }
using login.model;
User kate = new User("kate", "kakakakakakak");
User holly = new User("holly", "kakakqkkswkwo");

Dictionary<string, User> users = new Dictionary<string, User>(){
  {kate.Name, kate},
  {holly.Name, holly}
};
Console.Clear();
Console.WriteLine("Welcome to Skynet");
Console.Write("Username: ");
string? username = Console.ReadLine()?.ToLower();
Console.Write("Password: ");
string? password = Console.ReadLine()?.ToLower();
if (users.ContainsKey(username) && users[username].ValidatePassword(password))
{
  Console.WriteLine("this works");
}
else
{
  Console.WriteLine("doesnt work");

}