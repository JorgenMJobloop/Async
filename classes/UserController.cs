public class UserController
{
    User user = new User();
    CreateFile createFile = new CreateFile();
    public void CreateNewUser()
    {
        var user = new User
        {
            guid = new Guid(),
            Username = "John Doe",
            Password = "1234",
        };
        var user1 = new User
        {
            guid = new Guid(),
            Username = "John Smith",
            Password = ""
        };
        createFile.WriteLogFile("log.txt", $"New users created.\nguid:{user.guid}\nusername:{user.Username}\nguid:{user1.guid}\nusername{user1.Username}");
        Console.WriteLine($"New user created.\nguid: {user.guid}\nusername: {user.Username}");
    }
}