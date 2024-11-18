using System.Net.Http;
using System.Text.Json;

public class ClientClass
{
    public HttpClient client = new HttpClient();

    public async Task Run()
    {
        try
        {
            HttpResponseMessage response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/");
            if (Convert.ToInt32(response.StatusCode) != 200)
            {
                Console.WriteLine($"A HTTP error occured! {response.Headers}");
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                var jsonCotent = JsonDocument.Parse(content);
                string? output = JsonSerializer.Serialize(jsonCotent, new JsonSerializerOptions { WriteIndented = true });
                Console.WriteLine(output);
            }
        }
        catch (HttpRequestException error)
        {
            Console.WriteLine($"A HTTP Error occured: {error.Message}");
        }
    }
}