using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace Async;

class Program
{
    static async Task Main(string[] args)
    {
        ClientClass clientClass = new ClientClass();
        await clientClass.Run();

        UserController userController = new UserController();

        userController.CreateNewUser();
    }
}
