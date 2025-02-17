using System.Net.Http;
using System.Text.Json;

public class ClientClass
{
    public HttpClient client = new HttpClient();
    CreateFile createFile = new CreateFile();
    public async Task Run()
    {
        try
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:5000/api/movies");
            if (Convert.ToInt32(response.StatusCode) != 200)
            {
                Console.WriteLine($"A HTTP error occured! {response.Headers}");
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                var jsonCotent = JsonDocument.Parse(content);
                string? output = JsonSerializer.Serialize(jsonCotent, new JsonSerializerOptions { WriteIndented = true });
                createFile.WriteToFile("test.json", output);
                await File.WriteAllTextAsync("test1.json", output);
                Console.WriteLine(output);
            }
        }
        catch (HttpRequestException error)
        {
            Console.WriteLine($"A HTTP Error occured: {error.Message}");
        }
    }
}